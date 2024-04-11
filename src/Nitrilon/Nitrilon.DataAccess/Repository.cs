﻿using Microsoft.Data.SqlClient;

using Nitrilon.Entities;

namespace Nitrilon.DataAccess
{
    public class Repository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NitrilonDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public int Save(Event newEvent)
        {
            // TODO: handle attendees when the event is not yet over.
            // Don't forget to format a date as 'yyyy-MM-dd'
            string sql = $"INSERT INTO Events (Date, Name, Attendees, Description) VALUES ('{newEvent.Date.ToString("yyyy-MM-dd")}', '{newEvent.Name}', {newEvent.Attendees}, '{newEvent.Description}')";

            // 1: make a SqlConnection object:
            SqlConnection connection = new SqlConnection(connectionString);

            // 2: make a SqlCommand object:
            SqlCommand command = new SqlCommand(sql, connection);

            // TODO: try catchify this:
            // 3. Open the connection:
            connection.Open();

            // TODO: figure out how to get the new id created in the table.
            // 4. Execute the insert command
            command.ExecuteNonQuery();

            // 5. Close the connection when it is not needed anymore:
            connection.Close();

            return -1;
        }
    }
}
