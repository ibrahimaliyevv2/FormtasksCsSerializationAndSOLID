using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using Models;
using Newtonsoft.Json;

namespace NewEmployeeTask
{
    class Program
    {
        static string path = @"C:\Users\ibrahimaliyevv2\Desktop\";
        static void Main(string[] args)
        {
            
            string dicName = "DbFolder";
            DirectoryInfo directoryInfo = new DirectoryInfo(path+ dicName);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            string fileName = "database.json";
            FileInfo fileInfo = new FileInfo(path+ dicName+@"\"+fileName);

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            bool check = true;
            Department department = new Department();
            do
            {
                Console.WriteLine("======Menu=====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Get Employee By Id");
                Console.WriteLine("3. Remove Employee By Id");
                Console.WriteLine("0. Quit");
                Console.WriteLine("===============");

                byte choose = byte.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Iscinin adini daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Iscinin maasini daxil edin:");
                        double salary = double.Parse(Console.ReadLine());
                        Employee employee = new Employee(name, salary);
                        department.AddEmployee(employee);

                        var objectStr = JsonConvert.SerializeObject(department.Employees);
                        using (FileStream fileStream = new FileStream(path + dicName + @"\" + fileName, FileMode.Create))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.Write(objectStr);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Id daxil edin:");
                        int id = int.Parse(Console.ReadLine());

                        string ObjStr;
                        using (FileStream fileStream = new FileStream(path + dicName + @"\" + fileName, FileMode.Open))
                        {
                            StreamReader streamReader = new StreamReader(fileStream);
                            ObjStr = streamReader.ReadToEnd();
                        }

                        var user = JsonConvert.DeserializeObject<Employee>(ObjStr);
                        department.AddEmployee(user);
                        foreach (var item in department.Employees)
                        {
                            if (item.Id == id)
                            {
                                Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary}");
                            }
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Id daxil edin:");
                        int id2 = int.Parse(Console.ReadLine());

                        string ObjStr2;
                        using (FileStream fileStream = new FileStream(path + dicName + @"\" + fileName, FileMode.Open))
                        {
                            StreamReader streamReader = new StreamReader(fileStream);
                            ObjStr2= streamReader.ReadToEnd();
                        }

                        var user2 = JsonConvert.DeserializeObject<Employee>(ObjStr2);
                        department.AddEmployee(user2);
                        department.RemoveEmployee(id2);

                        var objectStr2 = JsonConvert.SerializeObject(department.Employees);
                        using (FileStream fileStream = new FileStream(path + dicName + @"\" + fileName, FileMode.Create))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.Write(objectStr2);
                            }
                        }
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }

            } while (check);
            
        }
    }
}
