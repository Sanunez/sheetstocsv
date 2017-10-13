# Welcome to SheetsToCSV
### <i>Description:</i> 
<p>SheetsToCSV is a tool that will translate a Google Sheets Spreadsheet into a .CSV (Comma Seperated Values) file. This application comes bundled with a settings counterpart that will configure it to work accordingly with any spreadsheet. This repo, once downloaded, should be run from Visual Studio, or alternatively the application can be installed as standalone using the installers in located in /Setups. </p>

<h2><strong>Sheets2CSV:</strong></h2>
<p>Sheets2CSV is organized into 3 different Levels:</p>

1. **Configuration Level**

   <p>The Configuration phase will decide weather or not the program should continue. It will locate a settings file and see if it has been configured. If it hasn't it will stop the program prompt the user with the directory of where to place settings file. Alternatively, if a settings file has been configured and placed correctly it will allow the program to into the Preparation Phase.</p>
  
1. **Preparation Level**

    <p>The Preparation phase takes care of establishing OAuth with Google API sheets. The User will be prompted to log in and give access to the application to their Google Drive. Once a successful connection is established, The program will check for the existance of previous files. If they exist, the program will proceed in "Appending Mode" otherwise, it will create new files and write headers. Once existance of files is decided the program will move on to the Execution Phase.</p>
    
1. **Execution Level**

    <p>At the Execution phase actual data is retrieved and processed. Data will be read from the Google Sheet, and be stored localy. Each row will be read in and copied over to Record File. Once Record is Written The row is processed by program and turned into an CRM Injection compatible .CSV file. The program will take note of where the last row was read in from and start from there next time it is run.</p>
    
    ![](https://imgur.com/OIkmAzW.png)

<h2><strong>Sheets2CSV Settings:</strong></h2>

|User Interface|Description|
|-------------------------------------------|--------------------------------------------------------------------------------------|
|<img src="https://i.imgur.com/UzCLfB0.png">|<p>The Sheets2CSV Settings application is alot more intuitive and user-friendly<br><br><strong>Output Directory:</strong> <br> This field directs the program as to where to place csv files<br><strong>Settings Output:</strong><br> This field should be populated with the directory specified in the Sheets2CSV application upon first run, since this path is where the settings file will be saved to.<br><strong>Spreadsheet ID:</strong> <br> This field should be populated by the target Google Sheet where information will be retrieved from.<br><strong>Entity:</strong><br>The Entity field should be whatever the spreadsheet contains, i.e. if it contains leads, write "Leads". If it includes contacts write "Contacts". However, use caution when naming since the entity will directly be used to create the CSV.<br><strong><i>So make sure to use correct spelling and capatilization if improting to database system or another software</i></strong><br><strong>Columns:</strong><br>The Columns are based on two things, Spreadsheet, and database. There must be a <strong><i>MINIMUM</i></strong> number of coulums specified here as there is data from the spreadsheet. If the csv will not be imported to any database then the name of the columns is arbitrary, but if you are the column names must be the same as what it's called in your database system. </p> |
