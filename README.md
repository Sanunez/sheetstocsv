<h1>SheetsToCSV</h1>
<h3><i>Description:</i></h3>
<p>SheetsToCSV is a tool that will translate a Google Sheets Spreadsheet into a .CSV (Comma Seperated Values) file. This application comes bundled with a settings counterpart that will configure it to work accordingly with any spreadsheet. This repo, once downloaded, should be run from Visual Studio, or alternatively the application can be installed as standalone using the installers in located in /Setups. </p>

<h2><strong>Sheets2CSV:</strong></h2>
<p>Sheets2CSV is organized into 3 different Levels:</p>

1. **Configuration Level**

   <p>The Configuration phase will decide weather or not the program should continue. It will locate a settings file and see if it has been configured. If it hasn't it will stop the program prompt the user with the directory of where to place settings file. Alternatively, if a settings file has been configured and placed correctly it will allow the program to into the Preparation Phase.</p>
  
1. **Preparation Level**

    <p>The Preparation phase takes care of establishing OAuth with Google API sheets. The User will be prompted to log in and give access to the application to their Google Drive. Once a successful connection is established, The program will check for the existance of previous files. If they exist, the program will proceed in "Appending Mode" otherwise, it will create new files and write headers. Once existance of files is decided the program will move on to the Execution Phase.</p>
    
1. **Execution Level**

    <p>At the Execution phase actual data is retrieved and processed. Data will be read from the Google Sheet, and be stored localy. Each row will be read in and copied over to Record File. Once Record is Written The row is processed by program and turned into an CRM Injection compatible .CSV file. The program will take note of where the last row was read in from and start from there next time it is run.</p>
