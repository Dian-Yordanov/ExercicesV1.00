using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    public string FirstName;
    public string LastName;
    string FN;
    public string Tel;
    public string Email;
    public List<int> Marks;
    public int GroupNumber;
    public Student()
    {
        Marks = new List<int>();
    }
    public Student(string fn, int gn) : this(fn, gn, "") { }
    public Student(string fn, List<int> gradelist)
    {
        FirstName = fn;
        Marks = gradelist;
    }

    public Student(string fn, int gn, string email) : this(fn, gn, email, "") { }
    public Student(string fn, int gn, string email, string tel)
    {
        FirstName = fn;
        GroupNumber = gn;
        Marks = new List<int>();
        Email = email;
        Tel = tel;
    }
}

class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = new List<Student>();
            stlist.Add(new Student("ivan", new List<int> { 2,3,4,5,3,5,2 }));
            stlist.Add(new Student("dragan", new List<int> { 2,5,6,3,4,6 }));
            stlist.Add(new Student("marin", new List<int> { 4,5,6,3,4,2 }));
            stlist.Add(new Student("velin", new List<int> { 6,6,6,6,6,6,2 })); 
            stlist.Add(new Student("ilian", new List<int> { 5,3,2,6,2, 2 }));
            stlist.Add(new Student("atanas", new List<int> { 3,4,2,4,2 }));

            var result = stlist.FindAll(x => 
            {
                return x.Marks.Count(y => y == 2) == 2;
            }).Select( x => new {FullName = x.FirstName+" "+x.LastName, Marks = x.Marks});

            foreach (var a in result)
            {
                Console.WriteLine("student {0} has 2 2 grades", a.FullName);
            }



        }
    }

