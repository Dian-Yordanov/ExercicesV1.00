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
    public string Email;
    List<int> marks;
    public int GroupNumber;
    public Student()
    {
        marks = new List<int>();
    }
    public Student(string fn, int gn) : this(fn, gn, "") { }
    
    public Student(string fn, int gn, string email)
    {
        FirstName = fn;
        GroupNumber = gn;
        marks = new List<int>();
        Email = email;
    }
}

class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = new List<Student>();
            stlist.Add(new Student("ivan", 1, "tarator@abv.bg"));
            stlist.Add(new Student("dragan", 2, "linq@sf.net"));
            stlist.Add(new Student("marin", 3, "fakeness@mail.bg"));
            stlist.Add(new Student("velin", 2, "musaka@gmail.com"));
            stlist.Add(new Student("ilian", 2, "ppphhh@mail.bg"));
            stlist.Add(new Student("atanas", 1, "hax@abv.bg"));

            var result = from p in stlist
                         where p.Email.IndexOf("@abv.bg") != -1
                         select p;

            foreach (var a in result)
            {
                Console.WriteLine("student {0} has a mail @abv.bg", a.FirstName);
            }



        }
    }

