//Write a program to print the details of the student if the student is a sports person then give extra 5 marks to that student

sing System;

namespace Test
{
    class Person
    {
        public string name;
        public string address;
        public string contactNo;

        public void getdata(string n, string a, string c)
        {
            name = n;
            address = a;
            contactNo = c; 
        }

        public void displaydata()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Address is: " + address);
            Console.WriteLine("Contact No. is: " + contactNo);
        }
    }

    interface Result
    {
        void CalculateResult(string sports, int m); 
    }

    class Student : Person, Result
    {
        public int id;
        public int marks;

        public void getdata(int i, int m)
        {
            id = i;
            marks = m;
        }

        public void displaydetail()
        {
            Console.WriteLine("ID is: " + id);
            Console.WriteLine("Marks is: " + marks);
        }

        public void CalculateResult(string s, int m)
        {
            if (s == "Y") 
            {
                m += 5; 
                Console.WriteLine("Total marks is: " + m);
            }
            else
            {
                Console.WriteLine("Total marks is: " + m); 
            }
        }
    }

    class Test
    {
        public static void Main()
        {
            Student s = new Student(); 
            s.getdata("Priya", "Delhi", "8929978980");
            s.getdata(1, 80);
            s.CalculateResult("Y", 80);
            s.displaydata();
            s.displaydetail();
        }
    }
}
