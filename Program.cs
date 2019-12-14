using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudentLibrary;

namespace Programm
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stas");
            StudentService service = new StudentService();
            service.Add(new Student
            {
                Name = "Karl",
                Age = 54,
                LastName = "Marx"
            });
            Random rand = new Random();
            foreach (Student item in service.Students)
            {
                item.AddMark("Biology", rand.Next(1, 12));
                item.AddMark("Physic", rand.Next(1, 12));
            }
            foreach (Student item in service.Students)
            {
                Console.WriteLine("Name : " + item.Name + "\nLast Name : " + item.LastName + "\nAge : " + item.Age + "\n");
            }
            
        }
    }
}
