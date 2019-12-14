using System;
using System.Collections.Generic;
using System.Text;
using static QualityTest.Models.Student;

namespace QualityTest.Models
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].IsDeactive()) { continue; }
                Console.WriteLine("{0, 10} | {1, 20} | {2,20} | {3,20} | {4,20} | {5,20} | {6,20} | {7,20}", i+1, students[i].RollNumber, students[i].FullName, students[i].Email, students[i].Birthday, students[i].Phone, students[i].CreatedAt, students[i].Status);
            }
            Console.ReadLine();
        }

        public Student CreateStudent()
        {
            Console.WriteLine("Nhap RollNo student : ");
            string rollNo = Console.ReadLine();

            Console.WriteLine("Nhap FullName student : ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Nhap Email student : ");
            string email = Console.ReadLine();

            Console.WriteLine("Nhap Birthday student : ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Nhap phone number student : ");
            string phone = Console.ReadLine();

            Console.WriteLine("Nhap status (1 - Active / 0 - Deactive):");
            var status = Convert.ToInt32(Console.ReadLine()) == 1 ? StudentStatus.Active : StudentStatus.Deactive;

            DateTime createdAt = DateTime.Now;

            return new Student {
                 RollNumber = rollNo,
                 FullName = fullName,
                 Birthday = birthday,
                 Email = email,
                 Phone = phone,
                 CreatedAt = createdAt,
                 Status = status
        };
        }
    }
}
