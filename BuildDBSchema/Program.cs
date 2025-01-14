using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Configuration;

internal class Program
{
    private static string? folder = ConfigurationManager.AppSettings["FileFolder"];
    private static List<string> tableColumns = new List<string>();

    private static void Main(string[] args)
    {

        CreateTable("npidata_pfile_20050523-20241208_fileheader.csv", "provider");
        CreateTable(folder + "othername_pfile_20050523-20241208_fileheader.csv", "provider_other_name");
        CreateTable(folder + "endpoint_pfile_20050523-20241208_fileheader.csv", "provider_endpoint");
        CreateTable(folder + "pl_pfile_20050523-20241208_fileheader", "provider_practice_location");
        Console.ReadKey();
    }

    private static void CreateTable(string filename, string tableName)
    {
        var csvFilePath = folder + filename;
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine($"File not found: {csvFilePath}");
            return;
        }

        try
        {
            // Open the CSV file using StreamReader
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string line;
                // Read the file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    var columns = line.Split(",");
                    foreach (var column in columns)
                    {
                        var colName = column.Replace("\"", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace(" ", "");

                        if (!tableColumns.Contains(colName) && !colName.Contains("_"))
                            tableColumns.Add(colName);
                    }    
                }
            }
            var createScript = new StringBuilder();
            createScript.Append(CreateTableHeader(tableName));
            int counter = 0;
            foreach (var col in tableColumns)
            {
                //Console.WriteLine("{0} - {1}", counter, col);  //used for creating the entity class
                createScript.Append(AddColumn(col, counter++ == 0));
            }
                
            createScript.Append(CreateTableFooter());
            
            //Console.WriteLine(createScript.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }

    private static string CreateTableHeader(string tableName)
    {
        var header = String.Format("CREATE TABLE {0} (", tableName);
        Console.WriteLine(header);
        return header;
    }
    private static string AddColumn(string colName, bool firstLine, string dataType = " varchar(255)")
    {
        var line = (firstLine ? "" : ",") + colName + dataType;
        Console.WriteLine(line);
        return line;
    }

    private static string CreateTableFooter()
    {
        var footer = ");";
        Console.WriteLine(footer);
        return footer;
    }
}