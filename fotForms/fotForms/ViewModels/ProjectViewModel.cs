using fotForms.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotForms.ViewModels
{
    class ProjectViewModel : MainController
    {
        public ProjectViewModel() { }

        public static async Task<List<Project>> GetProjectsInList()
        {
            await connection.OpenAsync();
            List<Project> projects= new List<Project>();

            using (var command = new NpgsqlCommand($"SELECT id, \"name\", code, is_finished FROM projects p ORDER BY (id)", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                for (int i = 0; await reader.ReadAsync(); i++)
                {
                    projects.Add(new Project());
                    projects[i].Id = reader.GetInt32(0);
                    projects[i].Name = reader.GetString(1);
                    projects[i].Code = reader.GetString(2);
                    projects[i].IsFinished = reader.GetBoolean(3);
                }
                await reader.CloseAsync();
                await connection.CloseAsync();
            }
            return projects;
        }

        public static async Task<Project> GetProject(int id = 1)
        {
            Project project = new Project();
            await connection.OpenAsync();
            using (var command = new NpgsqlCommand($"SELECT * FROM projects where id={id}", connection))
            {
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    Console.WriteLine($"GetEmployee: Обработка данных для проекта с id {reader.GetInt32(0)}");
                    project.Id = reader.GetInt32(0);
                    project.Name = reader.GetString(1);
                    project.Code = reader.GetString(2);
                    project.ClientName = reader.GetString(3);
                    project.ClientEmail = reader.GetString(4);
                    project.IsFinished = reader.GetBoolean(5);
                    project.BeginDate = reader.GetDateTime(6);
                    if (reader.IsDBNull(7)) project.EndDate = null;
                    else project.EndDate = reader.GetDateTime(7);
                }
                else
                {
                    Console.WriteLine("GetProject: данные не считаны");
                }
                await connection.CloseAsync();
                await reader.CloseAsync();
            }
            return project;
        }

        public static async Task<int> AddProject(Project project)
        {
            await connection.OpenAsync();
            string commandText = 
                $"INSERT INTO public.projects (\"name\", code, client_name, client_email, is_finished, begin_date, " +
                $"end_date) VALUES(@name, @code, @client_name, @client_email, @is_finished, @begin_date, @end_date);";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("name", project.Name);
                cmd.Parameters.AddWithValue("code", project.Code);
                cmd.Parameters.AddWithValue("client_name", project.ClientName);
                cmd.Parameters.AddWithValue("client_email", project.ClientEmail);
                cmd.Parameters.AddWithValue("is_finished", project.IsFinished);
                cmd.Parameters.AddWithValue("begin_date", project.BeginDate);
                cmd.Parameters.AddWithValue("end_date", project.EndDate == null ? DBNull.Value : project.EndDate);

                await cmd.ExecuteNonQueryAsync();
            }

            commandText = "SELECT id FROM projects ORDER BY(id) DESC ";
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


        public static async Task<int> UpdateProject(Project project)
        {
            await connection.OpenAsync();
            string commandText = 
                $"UPDATE public.projects SET \"name\"=@name, code=@code, client_name=@client_name, client_email=@client_email," +
                $" is_finished=@is_finished, begin_date=@begin_date, end_date=@end_date WHERE id={project.Id}";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("name", project.Name);
                cmd.Parameters.AddWithValue("code", project.Code);
                cmd.Parameters.AddWithValue("client_name", project.ClientName);
                cmd.Parameters.AddWithValue("client_email", project.ClientEmail);
                cmd.Parameters.AddWithValue("is_finished", project.IsFinished);
                cmd.Parameters.AddWithValue("begin_date", project.BeginDate);
                cmd.Parameters.AddWithValue("end_date", project.EndDate == null ? DBNull.Value : project.EndDate);

                await cmd.ExecuteNonQueryAsync();
            }
            await connection.CloseAsync();
            return project.Id;
        }

        public async static Task<bool> DeleteEmployee(int id)
        {
            await connection.OpenAsync();
            string commandText =
                $"DELETE FROM public.projects\r\nWHERE id={id}";
            try
            {
                await using (var cmd = new NpgsqlCommand(commandText, connection))
                {
                    await cmd.ExecuteNonQueryAsync();
                    await connection.CloseAsync();
                }
                return true;
            }
            catch
            {
                await Console.Out.WriteLineAsync("Удаление не удалось!!!");
                return false;
                throw;
            }
        }
    }
}
