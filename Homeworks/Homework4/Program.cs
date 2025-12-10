using System.Runtime.CompilerServices;

namespace Homework4;

class Student
{
    protected string name;
    protected int age;
    protected string group;
    public Student()
    {
        this.name = "No name";
        this.age = 0;
        this.group = "10.2";
    }
    public Student(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }
    public string Name
    {
        get{return name;}
        set{name = value;}
    }
    public int Age
    {
        get{return age;}
        set{age = value;}
    }
    public string Group
    {
        get{return group;}
        set{group = value;}
    }
    public void Study()
    {
        Console.WriteLine($"Student {this.name} whom is {this.age} years old is studying at a group {this.group}!");
    }
}

class Magistr: Student
{
    public void ProtectDiplome()
    {
        Console.WriteLine($"{this.name} is protecting a diplome!");
    }
}

class Bacalavr: Student
{
    public void TakeExam()
    {
        Console.WriteLine($"{this.name} is taking exam!");
    }
}
class Program
{
    static void Main()
    {
        Magistr person1 = new Magistr();
        person1.Name = "Bronislav";
        person1.Age = 20;
        person1.Group = "3";
        person1.Study();
        person1.ProtectDiplome();

        Bacalavr person2 = new Bacalavr();
        person2.Name = "Svyatoslav";
        person2.Age = 30;
        person2.Group = "9";
        person2.Study();
        person2.TakeExam();
    }
}
