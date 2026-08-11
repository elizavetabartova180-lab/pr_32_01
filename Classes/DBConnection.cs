using System;
using System.Data;
using System.Data.SqlClient;

namespace VinylRecordsApplication_Bartova.Classes
{
    public class DBConnection
    {
        public static DataTable Connection(string SQL)
        {
            DataTable dataTable = new DataTable("Datatable");

            SqlConnection sqlConnection = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;Database=VinylRecords;Trusted_Connection=True;");

            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = SQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}