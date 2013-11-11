using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Animal
{
    public static string IdentifyAnimal(Animal a)
    {
        string ret = a.ProduceSound();
        switch (ret)
        {
            case "...burp?": return "frog";
            case "bark...": return "dog";
            case "Meow Meow": return "cat";
            default: return ret;
        }
    }
    public uint age;
    public string name;
    public short sex;
    public Animal()
    {
        age = 0;
        name = "";
        sex = 0;
    }
    virtual public string ProduceSound() { return "unknown animal"; }
}

class Dog : Animal
{
    public override string ProduceSound()
    {
        return "bark...";
    }
    public Dog() : this("", 0, 0) { }
    public Dog(string name, uint age, short sex)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
}


class Frog : Animal
{
    public override string ProduceSound()
    {
        return "...burp?";
    }
    public Frog() : this("", 0, 0) { }
    public Frog(string name, uint age, short sex)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
}


class Cat : Animal
{
    public override string ProduceSound()
    {
        return "Meow Meow"; 
    }
}
class Kitten : Cat
{
    public Kitten() : this("", 0) { }
    public Kitten(string name, uint age)
    {
        sex = 2;
        this.name = name;
        this.age = age;
    }
}
class Tomcat : Cat
{
    public Tomcat() : this("", 0) { }
    public Tomcat(string name, uint age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
    {
    static double CalculateAvgAge(Animal[] a)
    {
        uint count = 0;
        uint sbor = 0;
        foreach (Animal aa in a)
        {
            sbor += aa.age;
            count++;
        }
        return (double)sbor / (double)count;
    }
        static void Main(string[] args)
        {
            Animal[,] aniarr = new Animal[4, 4];
            for (int i = 0; i < 4; i++) aniarr[0, i] = new Dog("Dog " + i, (uint)(i * 1.43 % 3), (short)(i % 3));
            for (int i = 0; i < 4; i++) aniarr[1, i] = new Frog("Frog " + i, (uint)(i * 1.85 % 4), (short)(i % 2));
            for (int i = 0; i < 4; i++) aniarr[2, i] = new Kitten("Kitten " + i, (uint)(i * 2.34 % 3));
            for (int i = 0; i < 4; i++) aniarr[3, i] = new Tomcat("Tomcat " + i, (uint)(i * 2.56 % 3));

            Console.WriteLine("animal [{0}, {1}] is a {2}", 3, 2, Animal.IdentifyAnimal(aniarr[3, 2]));

            
            Animal[] aarr2 = new Animal[4];
            for (int i = 0; i < 4; i++) aarr2[i] = aniarr[1, i];

            Console.WriteLine("Average age of Animal[{0}, *] is {1}", 1, CalculateAvgAge(aarr2));

        }
    }

