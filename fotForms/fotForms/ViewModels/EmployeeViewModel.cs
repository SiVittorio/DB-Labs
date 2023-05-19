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
    class EmployeeViewModel : MainController
    {
        #region Методы
        public static async Task<Employee> GetEmployee(int id = 1)
        {
            Employee employee = new Employee();

            await connection.OpenAsync();

            using (var command = new NpgsqlCommand($"SELECT * FROM employees where id={id}", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
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

                await reader.CloseAsync();
            }
            await connection.CloseAsync();
            return employee;
        }


        public static async Task<List<Employee>> GetEmployeesName()
        {
            await connection.OpenAsync();

            List<Employee> employees = new List<Employee>();

            using (var command = new NpgsqlCommand($"SELECT e.id, e.l_name, e.f_name, e.m_name FROM employees e", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                for (int i = 0; await reader.ReadAsync(); i++)
                {
                    employees.Add(new Employee());
                    employees[i].Id = reader.GetInt32(0);
                    employees[i].l_name = reader.GetString(1);
                    employees[i].f_name = reader.GetString(2);
                    employees[i].m_name = reader.GetString(3);
                }
                await reader.CloseAsync();
                await connection.CloseAsync();
            }
            return employees;

        }
        #endregion
    }
}
