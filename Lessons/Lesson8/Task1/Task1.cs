using MySql.Data.MySqlClient;
using System;

namespace Lessons.Lesson8.Task1
{
    class Task1
    {
        string Connection = "Database=test; Datasource=localhost; user=root; Password=;";

        public Task1()
        {
            int action;
            do
            {
                Console.WriteLine("Вывести список студентов(1)\n" +
                                  "Вывести информацию о студенте(2)\n" +
                                  "Удалить студента из списка(3)");
                int.TryParse(Console.ReadLine(), out action);
                switch (action)
                {
                    case 1:
                        GetAll();
                        break;
                    case 2:
                        GetInfo();
                        break;
                    case 3:
                        Delete();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Такого действия нет!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            } while (true);
        }

        void GetAll()
        {
            Console.Clear();
            using (MySqlConnection connect = new MySqlConnection(Connection))
            {
                connect.Open();
                string sql = "select * from students";
                MySqlCommand query = new MySqlCommand(sql, connect);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"id: {reader[0]}, name: {reader[1]}");
                }
                reader.Close();
                connect.Close();
            }
        }

        void GetInfo()
        {
            Console.Clear();
            Console.WriteLine("Введите фамилию студента");
            string name = Console.ReadLine();

            using (MySqlConnection connect = new MySqlConnection(Connection))
            {
                connect.Open();
                string sql = $"select * from students where FIO = '{name}'";
                MySqlCommand query = new MySqlCommand(sql, connect);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"id: {reader[0]}, name: {reader[1]}");
                }
                reader.Close();
                connect.Close();
            }
        }

        void Delete()
        {
            Console.Clear();
            Console.WriteLine("Введите фамилию студента");
            string name = Console.ReadLine();

            using (MySqlConnection connect = new MySqlConnection(Connection))
            {
                connect.Open();
                string sql = $"delete from students WHERE FIO = '{name}'";
                MySqlCommand query = new MySqlCommand(sql, connect);
                query.ExecuteNonQuery();
                connect.Close();
                Console.WriteLine($"Студент {name} был успешно удален");
            }
        }
    }
}
