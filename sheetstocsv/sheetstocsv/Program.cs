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

using Data = Google.Apis.Sheets.v4.Data;

namespace SheetsQuickstart
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheet to CSV";

        static NameValueCollection callTime = new NameValueCollection()
        {
            { "Morning", "100000000"  },
            { "Afternoon", "100000001" },
            { "Evening", "100000002" }
        };

        static void Main(string[] args)
        {
            UserCredential credential;
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
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
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1_VKKZ5J0DkBrx-Xi--4OEhkgpsdUSQIX5f2yV2U_4yU";
            string range = "A2:I";

            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            Data.ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            StreamWriter file = new StreamWriter("Lead_Sheet.csv");
            string[] headers =new string[] {"+new_createdon", "firstname", "lastname", "address1_postalcode", "emailaddress1", "telephone2", "new_isprimaryphonecellphone", "*new_besttimetocall", "subject" };
            file.Write("Entity, +new_createdon, firstname, lastname, address1_postalcode, emailaddress1, telephone2, new_isprimaryphonecellphone, *new_besttimetocall, subject\n");
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    file.Write("lead, ");
                    for(int i = 0; i < row.Count; i ++)
                    {
                        if(i == row.Count-1)
                        {
                            file.Write(row[i] + "\n");
                        }
                        else if (headers[i] == "telephone2")
                        {
                            file.Write(row[i].ToString().Replace(" ", "") + ", ");
                        }
                        else if(headers[i] == "*new_besttimetocall")
                        {
                            file.Write(callTime[row[i].ToString()] + ", ");
                        }
                        else
                        {
                            file.Write(row[i] + ", ");
                        }
                        
                    }
                }
            }
            //Console.Read();


        }
    }
}