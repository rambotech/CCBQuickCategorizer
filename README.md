# CCBQuickCategorizer

A Windows desktop application for Clear Checkbook (CCB) users.  It enables bulk categorization of a CSV export file containing all transactions.  It can also enable bulk-categorization of transactions in an import file, if you use import files (my guess is that most people don't).

##Motivation

This is a tool I wrote for my own end-of-year categorization, and is not written or supported by Clear Checkbook. I am making it available for other CCB users who also have expressed a desire for a faster way to add categories to transactions, so use it at your own risk.

As of the time I posted this project to GitHub, it worked without any problems or errors.  I won't support it: I don't get paid for that.  Make backups of any file you are going to edit, prior to working with that file in the application.

Clear Checkbook has been very responsive to its users, and has made improvements to auto categorizing.  Please view this application as having a limited lifespan and only filling a gap, until Clear Checkbook has the time to bring this type of functionality in the main website.

## Installing The Application
If you are an experienced developer who wants to have everything including source code, you know what to do.

If you have a Windows laptop or desktop and just want to use the application to categorize, do the following:
- Click the "Download ZIP" button above.  This will start the download to your downloads folder.
- Open your downloads folder in Windows Explorer, and locate the downloaded file.
- Right-click on the file, and select "Extract All..."
- In the dialog which appears, click the Browse button and select the desktop.  Tick the checkbox labeled "Show extracted files when complete", and click the Extract button.
- Go to your desktop and open the folder named "CCBQuickCategorizer-master", then open the folder "CCBQuickCategorizer_User" in the list.
- Look for a file named CCBQuickCategorizer.exe
- Double-click that file to start the program.  You will need to double-click the import and export file names, and navigate to this folder to select clearcheckbook.csv for the export file, and ccb_import.csv for the import file.

## Using the application
If you are going to bulk categorize your exsiting transactions in CCB, it involves the following steps:
- Exporting ALL the transactions in a CSV file from the CCB site.
- Making a backup copy of this backup file for safekeeping and later reference.
- Starting this tool and loading that export file into it.
- Adding categories, saving, and repeating until you are done.
- In CCB, deleting all transactions (important: only transactions, not categories or anything else)
- Using Tools/ Import the categorized export file you added transactions to.

## DANGER Will Robinson!
There is a shortcoming as of today (3/7/2016) to be aware of in Clear Checkbook. The web application will not add an imported transaction with an amount of zero.  While this may not seem like a problem, I personally log a voided check in CCB as VOID in the Payee with an amount of zero to have a full record of my checks' serial numbers.  That includes my errors. If you have anything like this in your transactions, they will not show back up in the transaction register after deleting the transactions and importing your categorized file.  They will have to be re-added manually.

##Checking Your Work

The best way to double check your work is to re-export ALL transactions after importing the categorized file, thenand compare the number of lines in the original export (which was categorized and imported) against the re-exported content. If the number of lines matches, you should be good.  If not, use a spreadsheet or a diff tool (like WinMerge) to compare the two files and see where the differences are.

In my case, in over 1,400 transactions that I categorized for a year, I only had seven transactions not imported. And they were all voided check entries.



