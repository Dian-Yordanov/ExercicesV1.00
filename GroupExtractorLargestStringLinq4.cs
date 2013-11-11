using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    public string FirstName;
    string LastName;
    string FN;
    public string Tel;
    public string Email;
    List<int> marks;
    public int GroupNumber;
    public Student()
    {
        marks = new List<int>();
    }
    public Student(string fn, int gn) : this(fn, gn, "") { }
    public Student(string fn, int gn, string email) : this(fn, gn, email, "") { }
    public Student(string fn, int gn, string email, string tel)
    {
        FirstName = fn;
        GroupNumber = gn;
        marks = new List<int>();
        Email = email;
        Tel = tel;
    }
}

class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = new List<Student>();
            stlist.Add(new Student("Petyr", 1, "tarator@abv.bg", "0423412"));
            stlist.Add(new Student("Georgi", 2, "linq@sf.net", "0234123024"));
            stlist.Add(new Student("Kiro", 3, "fakeness@mail.bg", "02673756"));
            stlist.Add(new Student("Ilian", 2, "musaka@gmail.com", "05574923"));
            stlist.Add(new Student("Ivan", 2, "ppphhh@mail.bg", "0245167"));
            stlist.Add(new Student("Atanas", 1, "hax@abv.bg", "06241659"));

            var result = from p in stlist
                         where p.Tel.Length >2 && p.Tel[0] == '0' && p.Tel[1] == '2'
                         select p;

            foreach (var a in result)
            {
                Console.WriteLine("student {0} has 02* telephone number", a.FirstName);
            }



        }
    }

