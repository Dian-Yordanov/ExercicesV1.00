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
    public Student(string fn, int gn)
    {
        FirstName = fn;
        GroupNumber = gn;
        marks = new List<int>();
    }
}

class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = new List<Student>();
            stlist.Add(new Student("Petyr", 1));
            stlist.Add(new Student("Georgi", 2));
            stlist.Add(new Student("Kiro", 3));
            stlist.Add(new Student("Velin", 2));
            stlist.Add(new Student("Atanas", 2));
            stlist.Add(new Student("Ilian", 1));

            var result = stlist.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (var a in result)
            {
                Console.WriteLine("student {0} is from group 2", a.FirstName);
            }



        }
    }

