using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;

using Data = Google.Apis.Sheets.v4.Data;

namespace SheetsQuickstart
{
    
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Drive};
        static string ApplicationName = "Google Sheet to CSV";

        static NameValueCollection callTime = new NameValueCollection()
        {
            { "Morning", "100000000"  },
            { "Afternoon", "100000001" },
            { "Evening", "100000002" }
        };

        static string configured, outputdir, spreadsheetID, headernum, entity, columns;
        static char[] delimiterChars = { ',' };

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Looking for Settings File in: " + Application.StartupPath);

            if (File.Exists("Settings.txt"))
            {
                Console.WriteLine("Settings File Found!");
                StreamReader infile = new StreamReader(@"Settings.txt");
                configured = infile.ReadLine();
                if (configured == "false")
                {
                    Console.WriteLine("Settings file has not been configured yet! Please Adjust Settings.");
                    Console.Read();
                    Environment.Exit(0);
                }
                else
                {
                    outputdir = infile.ReadLine();
                    spreadsheetID = infile.ReadLine();
                    headernum = infile.ReadLine();
                    entity = infile.ReadLine();
                    columns = infile.ReadLine();
                    infile.Close();
                    Console.WriteLine("Settings recieved Successfully!");
                }
                
            }
            else
            {
                Console.WriteLine("Settings File Missing! Please Refer to documentation!!");
                Console.Read();
                Environment.Exit(0);
            }

            

            #region Configuration Level
            string path = outputdir;
            //string value = outputdir;

            path = path + "\\";
            #endregion

            #region Preparation Level
                #region Sheets API
                UserCredential credential;
                using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                        credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-Sheetstocsv.json");

                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    //Console.WriteLine("Credential file saved to: " + credPath);
                }

                // Create Google Sheets API service.
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define request parameters.
                String spreadsheetId = spreadsheetID;
                char let = (char)(64 + Convert.ToInt32(headernum));
                string rows = "";
                int lastrow = 2;
                if(File.Exists("LastRun.txt"))
                {
                    StreamReader lastrun = new StreamReader("LastRun.txt");
                    rows = lastrun.ReadLine();
                    lastrun.Close();
                }
                else
                {
                    rows = "2";
                }     
                string range = "A" + rows + ":" + let;

                SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

                Data.ValueRange response = request.Execute();
                IList<IList<Object>> values = response.Values;
                #endregion  

                Boolean fileExist;

                //Check for File
                if (File.Exists(path + "Lead_Sheet.csv"))
                {
                    fileExist = true;
                }
                else
                {
                    fileExist = false;
                }
                Console.Write(fileExist);

                //Setup File IO
                StreamWriter file = new StreamWriter(path+ entity + "_Sheet.csv", true);
                StreamWriter injectionfile = new StreamWriter(path+entity+"_inject.csv");

                //Set up Headers
                string[] headers = columns.Split(delimiterChars);
                /*{
                    "+new_createdon",
                    "firstname",
                    "lastname",
                    "address1_postalcode",
                    "emailaddress1",
                    "telephone2",
                    "new_isprimaryphonecellphone",
                    "*new_besttimetocall",
                    "subject"
                    /*
                    "fname",
                    "lname",
                    "org_name",
                    "member_role"
                };
                */
                
                //Check for exisitng records
                if (!fileExist)
                {
                    file.Write(entity + ", " + columns+ "\n");
                }
                injectionfile.Write(entity + ", " + columns +"\n");
            #endregion

            #region Execution Level
            //Handle Retrieved Data
            if (values != null && values.Count > 0)
                {
                    foreach (var row in values)
                    {
                        lastrow++;
                        file.Write(entity + ", ");
                        injectionfile.Write(entity + ", ");
                        for(int i = 0; i < row.Count; i ++)
                        {
                            if(i == row.Count-1)
                            {
                                file.Write(row[i]);
                                injectionfile.Write(row[i]);
                            }
                            if (headers[i] == "address1_postalcode")
                            {
                                string r = row[i].ToString();
                                if (r.Length > 5)
                                {
                                    file.Write(r.Substring(0, 5)+", ");
                                    injectionfile.Write(r.Substring(0, 5) + ", ");
                                }
                                else
                                {
                                    file.Write(row[i] + ", ");
                                    injectionfile.Write(row[i] + ", ");
                                }
                            }
                            else if (headers[i] == "telephone2")
                            {
                                string val = row[i].ToString();
                                val = val.Replace("-", string.Empty);
                                val = val.Replace(" ", string.Empty);
                                val = val.Replace("(", string.Empty);
                                val = val.Replace(")", string.Empty);
                                val = val.Replace(".", string.Empty);
                                if (val.Length > 10){val = val.Substring(0, 10);}
                                file.Write(val + ", ");
                                injectionfile.Write(val + ", ");

                            }
                            else if (headers[i] == "new_isprimaryphonecellphone")
                            {
                                if (row[i].ToString() == "Yes")
                                {
                                    file.Write("TRUE" + ", ");
                                    injectionfile.Write("TRUE" + ", ");
                                }
                                else
                                {
                                    file.Write("FALSE" + ", ");
                                    injectionfile.Write("FALSE" + ", ");
                                }
                            
                            }
                            else if(headers[i] == "*new_besttimetocall")
                            {
                                file.Write(callTime[row[i].ToString()] + ", ");
                                injectionfile.Write(callTime[row[i].ToString()] + ", ");
                            }
                            else
                            {
                                file.Write(row[i] + ", ");
                                injectionfile.Write(row[i] + ", ");
                            }
                        
                        }
                        file.Write("\n");
                        injectionfile.Write("\n");
                    }
                }


            /*string ClearRange = "A2:Z";
            Data.ClearValuesRequest requestBody = new Data.ClearValuesRequest();
            SpreadsheetsResource.ValuesResource.ClearRequest clearRequest = service.Spreadsheets.Values.Clear(requestBody, spreadsheetId, ClearRange);
            Data.ClearValuesResponse clearResponse = clearRequest.Execute();*/
            file.Close();
            injectionfile.Close();

            StreamWriter lastout = new StreamWriter("LastRun.txt");
            lastout.WriteLine(lastrow);
            lastout.WriteLine(DateTime.Today);
            lastout.Close();
            #endregion



        }
    }
}