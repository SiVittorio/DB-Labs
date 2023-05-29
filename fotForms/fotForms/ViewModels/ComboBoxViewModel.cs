using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace fotForms.ViewModels
{
    internal class ComboBoxViewModel : MainController
    {
        #region Методы

        public static async Task<List<string>> GetData(string tableName, string columnName)
        {
            var list = new List<string>();
            await connection.OpenAsync();

            using (var command  = new NpgsqlCommand($"SELECT \"{columnName}\" FROM {tableName}", connection)) 
            {
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    list.Add(reader.GetString(0));
                }

                await reader.CloseAsync();
            }

            await connection.CloseAsync();

            return list;

        }
        #endregion
    }
}
