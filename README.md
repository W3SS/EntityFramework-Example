# EntityFramework-Example
Simple example of how to use entity framework

This is a simple console application using Entity framework. It details how to use the dbcontext and entity configurations. Also how  to generate scripts

##Usage 
Create a database called EfTutorial
Run the migrations
For this you need to run the command : 
Update-Database -Script -ConfigurationTypeName ContextConfiguration -Verbose -ConnectionString "Data Source=.;Initial Catalog=EfTutorial;Integrated Security=True;" -ConnectionProviderName "System.Data.SqlClient"
this will generate a script that you will then manually run against your database. remove the -script and it will run it against the db itself. 

This assumes that you already have a database called EfTutorial on your local sql server instance

For references, if you want to modify the note class to further experiment, you can delete the initial migration and add another one (or simply add another migration) with this command: 

Add-Migration -Verbose -ConfigurationTypeName ContextConfiguration -ConnectionString "Data Source=.;Initial Catalog=EfTutorial;Integrated Security=True;" -ConnectionProviderName "System.Data.SqlClient" InitialMigration
InitialMigration is the name of the migration you're adding. You're running these commands in the package manager console (Tools->Nuget Package Manager)

Start the project