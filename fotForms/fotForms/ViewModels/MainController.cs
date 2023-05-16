using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fotForms.Models;
using fotForms.Views;

namespace fotForms.ViewModels
{
    internal class MainController
    {
        #region Методы
        public MainController() { }

        public static Employee GetEmployee(int id = 1)
        {
            Employee employee = new Employee();
            
            connection.Open();

            using (var command = new NpgsqlCommand($"SELECT * FROM employees where id={id}", connection))
            {
                var reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    Console.WriteLine($"GetEmployee: Обработка данных для пользователя с id {reader.GetInt32(0)}");
                    employee.Id = reader.GetInt32(0);
                    employee.f_name = reader.GetString(1);
                    employee.m_name = reader.GetString(2);
                    employee.l_name = reader.GetString(3);
                    employee.reg_date = reader.GetDateTime(4);
                    employee.email = reader.GetString(5);
                    employee.phone = reader.GetString(6);
                }
                else
                {
                    Console.WriteLine("GetEmployee: данные не считаны");
                }

                reader.Close();
            }
            connection.Close();
            return employee;
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
