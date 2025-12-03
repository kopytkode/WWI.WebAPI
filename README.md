# WWI.WebAPI

### Project Description
This project serves as a *starting point* for the COMP268 - Enterprise Application Development 2 final project. It is created by the faculty of Business Information Systems at Saskatchewan Polytechnic.

### Data Context
WWI.WebAPI uses the sample database of Wide World Importers (WWI) created by Microsoft.

In COMP267 and COMP268 WWI is used to learn about RESTful APIs, enterprise patterns, DevOps, and agile methodologies.

### Database Connection
In **appsettings.json**, there is a connection string to a *localhost database*.  If your local environment does not use localhost, be sure to update your connection string!

**If you do not have a local copy of WWI DB**, you can download a .bak from the link below and restore the database on your localhost. 
[https://github.com/Microsoft/sql-server-samples/releases/tag/wide-world-importers-v1.0](url)

### API Endpoint Testing
The API is configured with Swagger UI. To navigate to the Swagger page, run the project locally, and append **/swagger** to your https URL. 

The starter project comes with a ***/dbtest*** endpoint to confirm the database connection works. This test is written directly in Program.cs for simplicity. 

### How To Run This Project
Clone the repository and open the project in Visual Studio (VS).

Run the project using VS and navigate to the /swagger URL. There is a single /dbtest endpoint you can attempt. If the database can successfully connect, a "Connected" message appears as a response. 
