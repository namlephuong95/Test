using QualityTest.Models;
using System;
using System.Collections.Generic;

namespace QualityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        static void GenerateMenu()
        {
            var listStudent = new List<Student>();
            var controller = new StudentController();
            while (true)
            {
                Console.WriteLine("\t Menu");

                Console.WriteLine("1. Them sinh vien moi.");

                Console.WriteLine("2. Hien thi danh sach sinh vien.");

                Console.WriteLine("3. Thoat.");

                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Them moi sinh vien");
                        var student = controller.CreateStudent();
                        listStudent.Add(student);
                        break;

                    case 2:
                        Console.WriteLine("Danh sach sinh vien : ");
                        controller.PrintListStudent(listStudent);
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!!!");
                        break;

                    default:
                        Console.WriteLine("Choose = 1, 2 or 3");
                        break;
                }
                if (choose == 3)
                {
                    break;
                }
            }
        }
    }
}
