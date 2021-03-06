# Zahar: C# Transaction Script Code Generator
## Goals

Simple C# data access code generator for SQL Server Database.
The generated code shall 

- Be stored procedure centric (Transaction Script pattern)
- Embrace the native ADO.NET provider object model (SqlCommand, SqlDataReader etc.), and thus not become a framework on its own
- Simplify 
	* building SqlCommand objects
	* consuming tabular results returned by queries
	* consuming procedure output- and return- values

## Design

### Comand Builders
For selected stored procedures the generator shall create a dedicated command builder C# class confirming to the following 
- Stored procedure parameter values can be set using strongly typed instance-level properties named accordinally
- Table Value parameters are represented with properties of the DataTable type
- The instance BuildCommand- method shall yield a preconfigured and ready to use SqlCommand 
- The instance BuildRecordAdapter- method shall convert the given SqlDataReader object to a stronly typed data record type defined by the generator
- The instance BuildOutputValues- values shall convert the given SqlCommand to a stronly typed set of return and output- values
	
### Comand Builder Factory
Command builder factory C# class, generated per database, shall provide a set of Create[Schema Name][Stored Procedure Name]CmdBuilder- factory methods 
to simplify creating the command builders
	
## Example:
```cs
            var factory = new MyDbCmdBuilderFactory("Connection string goes here...");
            var builder = factory.CreateDboMyStoredProcedureCmdBuilder();
			builder.Id = 10;                  // set the @Id stored procedure parameter value to 10
			builder.UntilDate = DateTime.Now; // set the @UntilDate stored procedure parameter value to DateTime.Now
			
            using (SqlConnection connection = factory.CreateConnection())
            using (SqlCommand command = builder.BuildCommand(connection))
            {
                await connection.OpenAsync();
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    var current = builder.BuildRecordAdapter(reader);
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}: {1}", current.ItemName, current.ItemDescription);
                    }
                    reader.Close();
                    var output = builder.BuildOutputValues(command);
                    Console.WriteLine(outout.RETURN_VALUE);
                }
            }	
```

