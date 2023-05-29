using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fotForms.Models;
using fotForms.Views;
using System.Security.Cryptography;




namespace fotForms.ViewModels
{
    internal class MainController
    {
        #region Методы
        public MainController() { }
        /// <summary>
        /// Получить количество данных
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static int GetRowsCount(string tableName)
        {
            connection.Open();

            using (var command = new NpgsqlCommand($"SELECT COUNT(*) FROM {tableName}", connection))
            {
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    reader.Close();
                    connection.Close();
                    return count;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return 0;
                }
            }
        }
        /// <summary>
        /// Получить количество свойств
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static async Task<int> GetColumnsCount(string tableName)
        {
            await connection.OpenAsync();

            using (var command = new NpgsqlCommand($"SELECT * FROM columns_count('{tableName}')", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    int count = reader.GetInt32(0);
                    Console.WriteLine($"Количество строк в таблице {tableName} - {count}");
                    await reader.CloseAsync();
                    await connection.CloseAsync();
                    return count;
                }
                else
                {
                    Console.WriteLine($"Ошибка получения количества строк в таблице {tableName}");
                    await reader.CloseAsync();
                    await connection.CloseAsync();
                    return 0;
                }
            }
        }
        /// <summary>
        /// Получить список названий свойств
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static async Task<List<List<string>>> GetColumnsList(string tableName)
        {
            //Task<List<Dictionary<string, List<string>>>>
            await connection.OpenAsync();

            using (var command = new NpgsqlCommand($"SELECT * FROM columns_list('{tableName}')", connection))
            {
                var reader = await command.ExecuteReaderAsync();
                List<List<string>> colNames = new List<List<string>>();
                
                for (int i = 0; await reader.ReadAsync(); i++)
                {
                    colNames.Add(new List<string>());
                    colNames[i].Add(reader[1].ToString());
                    colNames[i].Add(reader[2].ToString());
                }
                await reader.CloseAsync();
                await connection.CloseAsync();

                return colNames;

            }
        }
        /// <summary>
        /// Получить ID по значению
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static async Task<int> GetId(string tableName, string columnName, string value)
        {
            await connection.OpenAsync();

            using (var command = new NpgsqlCommand
                ($"SELECT id FROM columns_list('{tableName} WHERE \"{columnName}\" = \'{value}\'')", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                int id = reader.GetInt32(0);
                await reader.CloseAsync();
                await connection.CloseAsync();

                return id;

            }
        }
        #endregion

        #region Свойства
        #region Public

        public static NpgsqlConnection connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder("Host=localhost;Port=5432;Database=fot;Username=postgres;Password=3568").ToString());
        #endregion

        #region Private
        #endregion

        #endregion

    }
}
