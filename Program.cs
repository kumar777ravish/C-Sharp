﻿using System;

namespace OOP_s1
{
    class Student
    {
        int Sid;
        string Name;
        double M1, M2;

        public void CreateStudent(int id, string name)

        public void SetMarks(double m1, double m2)

        public void Results()
    }
    class Program
    {
        Student S;
        S = new Student();

        Console.WriteLine("Enter Sid And Name");
            int id = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();

        S.CreateStudent(id, name);

            Console.WriteLine("Enter Marks 1 and 2");
            double m1 = double.Parse(Console.ReadLine());
        double m2 = double.Parse(Console.ReadLine());

        S.SetMarks(m1, m2);

            S.Result();
            S.CreateStudent(200, "Ravish"); //Re-initialise the object - issue 2


            //Student S1 = new Student();
            //S1.CreateStudent(200, "Ravish");
            Console.WriteLine("Hello World!");
        }

    class,Fields,Methods And Objects

        class Student
    {
        int Sid;
        string Name;
        double M1, M2;
    }
    public Student(int id, string name)
    {
        Sid = id;
        name = name;
    }
    public void SetMarks(double m1, double m2)
    {
        M1 = m1;
        M2 = m2;
    }
    public void Result()
    {
        duble avg = (M1 + M2) / 2;
        if (avg >= 35)
        {
            Console.WriteLine("Pass");
        }
        else
        {


            Console.WriteLine("Fail");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student S = new Student(100, "peter");
        S.SetMarks(23, 45);

        S.Result();
        //S.Student(200, "Ravish");

        #region Constructors
        class Student
    {
        int Sid;
        string Name;
        double M1, M2;
        string Contact;

        public Student()
        {
            Console.WriteLine("This is default Constructors")
        }

        public S(int id, string name, string contact)
        {
            Sid = id;
            Name = name;
            Contact = contact;
        }

        public void SetMarks(m1, m2)
        {
            M1 = m1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(200, "Ravish");


            Student S = new Student(100, "Peter");

            S.SetMarks(23, 45);

            S.Result();

            //S.Student(200, "Ravish");

            public void Result()
            {
                double avg = (M1 + M2) / 2;
                if (avg >= 35)
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            public void Result(double minAvgToPass)
            {
                double avg = (M1 + M2) / 2;
                if (avg >= minAvgToPass)
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
        }

        Constructors

        Constructors Overloading, this keyboard, Method Overloading


        int Sid;
        string Name;
        public student(int id, string Name)
        {
            this.Sid = Sid;
            this.Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            var s = new Student(100, "peter")
            int Sid =GetSid
            Console






    }


  
        {  
                var S = new Student












        Console.ReadLine();
        }
    }







          












        

    
    
        
        
    

        
       
    


    
    {
       
        {
        }
    }
}
