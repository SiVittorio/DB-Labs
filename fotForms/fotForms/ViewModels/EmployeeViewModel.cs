﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fotForms.Models;
using fotForms.Views;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace fotForms.ViewModels
{
    class EmployeeViewModel : MainController
    {
        #region Методы
        /// <summary>
        /// Получить объект сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                    employee.F_name = reader.GetString(1);
                    employee.Mid_name = reader.GetString(2);
                    employee.L_name = reader.GetString(3);
                    employee.Reg_date = reader.GetDateTime(4);
                    employee.Email = reader.GetString(5);
                    employee.Phone = reader.GetString(6);
                }
                else
                {
                    Console.WriteLine("GetEmployee: данные не считаны");
                }
                await connection.CloseAsync();
                await reader.CloseAsync();
            }
            return employee;
        }
        /// <summary>
        /// Получить ФИО сотрудника
        /// </summary>
        /// <returns></returns>
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
                    employees[i].L_name = reader.GetString(1);
                    employees[i].F_name = reader.GetString(2);
                    employees[i].Mid_name = reader.GetString(3);
                }
                await reader.CloseAsync();
                await connection.CloseAsync();
            }
            return employees;

        }

        public static async Task<int> AddEmployee(Employee employee)
        {
            await connection.OpenAsync();
            string commandText = $"INSERT INTO public.employees (f_name, m_name, l_name, email, phone) VALUES(@f_name, @m_name, @l_name, @email, @phone)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("f_name", employee.F_name);
                cmd.Parameters.AddWithValue("m_name", employee.Mid_name);
                cmd.Parameters.AddWithValue("l_name", employee.L_name);
                cmd.Parameters.AddWithValue("email", employee.Email);
                cmd.Parameters.AddWithValue("phone", employee.Phone);

                await cmd.ExecuteNonQueryAsync();
            }

            commandText = "SELECT id FROM employees ORDER BY(id) DESC ";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                var reader = await cmd.ExecuteReaderAsync();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    await connection.CloseAsync();
                    return id;
                }
                else
                {
                    await connection.CloseAsync();
                    return 0;
                }
            }
        }


        public async static Task AddEmplyeeInfo(EmployeeInfo employeeInfo)
        {
            await connection.OpenAsync();
            string commandText = 
                $"INSERT INTO public.employee_info (employee_id, job_id, rank_id, sci_job_id, main_work_id) VALUES(@employee_id, @job_id, @rank_id, @sci_job_id, @main_work_id)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("employee_id", employeeInfo.EmployeeId);
                cmd.Parameters.AddWithValue("job_id", employeeInfo.JobId);
                cmd.Parameters.AddWithValue("rank_id", employeeInfo.RankId);
                cmd.Parameters.AddWithValue("sci_job_id", employeeInfo.SciJobId);
                cmd.Parameters.AddWithValue("main_work_id", employeeInfo.MainWorkId);

                await cmd.ExecuteNonQueryAsync();
                await connection.CloseAsync();
            }
        }
        #endregion
    }
}
