using System;
using System.Collections.Generic;
using System.Text;

namespace QualityTest.Models
{
    class Student
    {
        public enum StudentStatus
        {
            Deactive = 0,
            Active = 1
        }
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public StudentStatus Status { get; set; }

        public Student() { }
        public Student(string RollNumber, string FullName, DateTime Birthday, string Email, string Phone, DateTime CreatedAt, StudentStatus Status) {
            this.RollNumber = RollNumber;
            this.FullName = FullName;
            this.Birthday = Birthday;
            this.Email = Email;
            this.Phone = Phone;
            this.CreatedAt = CreatedAt;
            this.Status = Status;
        }

        public bool IsNewStudent()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = this.CreatedAt;
            double totalDays = (d1 - d2).TotalDays;
            if (totalDays <= 60)
            {
                return true;
            }
            return false;
        }

        public bool IsDeactive()
        {
            return this.Status == StudentStatus.Deactive;
        }

    }
}
