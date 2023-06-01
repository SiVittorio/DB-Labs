using fotForms.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fotForms.ViewModels
{
    internal class TitleScreenViewModel : MainController
    {
        public async static Task<Dictionary<string, double>> GetFotYear()
        {
            Dictionary<string, double> data = new Dictionary<string, double>();
            await connection.OpenAsync();
            using (var command = new NpgsqlCommand($"SELECT * FROM fotperyear", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    data.Add(reader.GetString(0), reader.GetDouble(1));
                }
                await connection.CloseAsync();
                await reader.CloseAsync();
            }
            return data;
        }

        public async static Task<Dictionary<KeyValuePair<int, int>, double>> GetFotMonth()
        {
            Dictionary<KeyValuePair<int, int>, double> data = new Dictionary<KeyValuePair<int, int>, double>();
            await connection.OpenAsync();
            using (var command = new NpgsqlCommand
                ($"SELECT mi.\"date\", f.sum FROM fotpermonth f JOIN month_info mi ON mi.id = f.id", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    
                    data.Add(new KeyValuePair<int, int>(reader.GetDateTime(0).Year ,reader.GetDateTime(0).Month), reader.GetDouble(1));
                }
                await connection.CloseAsync();
                await reader.CloseAsync();
            }
            return data;
        }

    }
}
