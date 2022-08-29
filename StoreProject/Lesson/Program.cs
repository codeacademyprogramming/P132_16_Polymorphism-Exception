using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human()
            //{
            //    Name = "Hikmet",
            //    Surname = "Abbasov"
            //};

            Student student = new Student()
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                GroupNo = "P123"
            };

            string text = student.ToString();
            Console.WriteLine(student);


            int num = 1450;
            byte age = 50;

            num = age;
            //age = (byte)num;
            //age = Convert.ToByte(num);


            //boxing
            object ageObj = age;

            //unboxing
            age = (byte)ageObj;


            Console.WriteLine(age);


            Student std1 = new Student
            {
                Name = "Seymur",
                GroupNo = "P132"
            };

            Human stdHuman = std1;


            Student std2 = (Student)stdHuman;

            Console.WriteLine(std2.GroupNo);

            WarrantyStudent warrantyStd = new WarrantyStudent
            {
                Name = "Nermin",
                GroupNo = "P132",
                PrevGroupNo = "P111"
            };


            Human human3 = new Student
            {
                Name = "Abbas",
                GroupNo = "P123"
            };

            Employee employee = new Employee
            {
                Name = "Ramin",
                Position = "muhasib",
            };

            Human human4 = employee;

            bool check = human4 is Student;
            Console.WriteLine(check);

            //var std4 = (Student)human4;

            //Console.WriteLine(std4.Name);


            Student std3 = warrantyStd;

            Console.WriteLine("=====================");
            human3.ShowInfo();
            std3.ShowInfo();



            Human[] humans = new Human[] { std1, warrantyStd, new Employee { Name = "Tofiq", Surname = "Abbasov", Position = "developer" },employee };

            for (int i = 0; i < humans.Length; i++)
            {
                if(humans[i] is Employee)
                {
                    Employee emp = (Employee)humans[i];
                    Console.WriteLine(emp.Position);
                }
            }
        }
    }

}
