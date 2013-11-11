using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class Human
{
    public string firstName;
    public string lastName;
    public Human(string firstName, string lastName);
    public Human() : this("", "") { }
}

public class Student : Human
{
    public uint grade;
    public Student(uint grade);
    public Student() : this(0) { }

}

public class Worker : Human
{
    public uint weekSalary;
    public uint workHours;
    public Worker(uint weekSalary, uint workHours)
    {
        weekSalary = weekSalary;
        workHours = workHours;
    }

    public Worker() : this(0, 1) { }

    public double MoneyPerHour()
    {
        //assuming that there are 5 days in the week that the worker go to work
        return (double)weekSalary / 5.0 / (double)workHours;
    }
}


class Program
{

    static int cmpfunctst(Student a, Student b)
    {
        return (int)(a.grade - b.grade);
    }

    static int cmpfunctwork(Worker a, Worker b)
    {
        return (b.MoneyPerHour() - a.MoneyPerHour()) >= 0 ? ((b.MoneyPerHour() - a.MoneyPerHour()) == 0 ? 0 : 1) : -1;
    }

    static void Main(string[] args)
    {
        Random rnd = new Random(System.DateTime.Now.Minute * System.DateTime.Now.Millisecond / System.DateTime.Now.Second);

        Student[] a = new Student[10];
        //first 10 ppl from skype
        string[] fnames = new string[10] { "valentina", "Glory", "Blago", "Nikolai", "Ico", "Pesho", "ilian", "Evka", "Kolio", "Cec" };
        string[] lnames = new string[10] { "ivanova", "ivanov", "atanasov", "damajanov", "kojuharov", "petrov", "atanasova", "kalinov", "ivanov", "vencislalov" };

        for (int i = 0; i < 10; i++)
        {
            a[i] = new Student((uint)(rnd.Next(10) + 2));
            a[i].firstName = fnames[i];
            a[i].lastName = lnames[i];
        }

        System.Comparison<Student> cmp = new Comparison<Student>(cmpfunctst);
        Array.Sort<Student>(a, cmp);

        foreach (Student sa in a)
        {
            Console.WriteLine("Student {0} {1} - grade {2}", sa.firstName, sa.lastName, sa.grade);
        }

        Console.WriteLine("\n\n");

        Worker[] workarr = new Worker[10];
        for (int i = 0; i < 10; i++)
        {
            workarr[i] = new Worker((uint)rnd.Next(1000) + 200, (uint)rnd.Next(30) + 10);
            workarr[i].firstName = fnames[i];
            workarr[i].lastName = lnames[i];
        }

        System.Comparison<Worker> workcmp = new Comparison<Worker>(cmpfunctwork);
        Array.Sort<Worker>(workarr, workcmp);
        foreach (Worker wa in workarr)
        {
            Console.WriteLine("worker {0} {1} - {2} per hour", wa.firstName, wa.lastName, wa.MoneyPerHour());
        }
    }
}

