using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using NPPES_Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProviderData
{
    internal abstract class DataLoadBase
    {
        protected int batchSize = 200;
        protected int skip = 0;
        protected int limit = 0;

        protected int total = 0;

        protected string? folder = ConfigurationManager.AppSettings["FileFolder"];
        protected string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        protected void LoadDataFromFile(string filename, string tableName, int expectedCols, Action<string[]> rowMethod, Action batchMethod)
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
                using (TextFieldParser parser = new TextFieldParser(csvFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    int counter = 0;
                    string[] fields = parser.ReadFields() ?? [];
                    if (fields.Length != expectedCols)
                        throw new Exception($"Incorrect number of columns in file! Expected: {expectedCols}, but was: {fields.Length}");

                    // Read the file line by line
                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields() ?? [];
                        if (counter++ < skip)
                            continue;

                        rowMethod(fields);
                        // Print the line to the console
                        //Console.WriteLine(line);

                        if (batchSize > 0 && ((counter - skip) % batchSize == 0))
                        {
                            batchMethod();
                        }

                        if (limit > 0 && ((counter - skip) >= limit))
                        {
                            break;
                        }
                    }
                    batchMethod();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        protected string BuildInsert(string tableName, string firstLine)
        {
            return String.Format("Insert INTO {0} ({1}) VALUES ", tableName, firstLine.Replace("\"", "").Replace(" ", ""));
        }

        protected void PerformInsert<T>(List<T> records) where T: EntityBase
        {
            StringBuilder sql = new StringBuilder();

            if (records.Count == 0)
            {
                Console.WriteLine($"No {typeof(T).Name} records to Insert");
                return;
            }

            try
            {
                //Console.SetCursorPosition(0, 0);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DoInsert(connection, records);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Number} - {ex.Message}");
                Console.WriteLine("SQL: " + sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        protected abstract void DoInsert<T>(MySqlConnection connection, List<T> records) where T : EntityBase;

        protected int InsertRecords<T>(MySqlConnection connection, List<T> records, ref int total) where T: EntityBase
        {
            StringBuilder sql = new StringBuilder();
            bool first = true;
            int rowsAffected = 0;

            foreach (var record in records)
            {
                sql.Append(record.InsertQuery(!first));
                first = false;
            }

            using (MySqlCommand command = new MySqlCommand(sql.ToString(), connection))
            {

                rowsAffected = command.ExecuteNonQuery();
                total += rowsAffected;
                Console.WriteLine($"{typeof(T).Name} rows inserted: {rowsAffected} ({total} total)");
            }
            return rowsAffected;
        }
    }
}
