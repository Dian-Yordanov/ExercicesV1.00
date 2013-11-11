using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    public string FirstName;
    string LastName;
    string FN;
    string Tel;
    string Email;
    List<int> marks;
    public int GroupNumber;
    public Student()
    {
        marks = new List<int>();
    }
    public Student(string firstName, int groupName)
    {
        FirstName = firstName;
        GroupNumber = groupName;
        marks = new List<int>();
    }
}

class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = new List<Student>();
            stlist.Add(new Student("Atanas", 1));
            stlist.Add(new Student("Ilian", 2));
            stlist.Add(new Student("Velin", 3));
            stlist.Add(new Student("Marin", 2));
            stlist.Add(new Student("Dragan", 2));
            stlist.Add(new Student("Ivan", 1));

            var result = from p in stlist
                         where p.GroupNumber == 2
                         orderby p.FirstName
                         select p;

            foreach (var a in result)
            {
                Console.WriteLine("student {0} is from group 2", a.FirstName);
            }



        }
    }

