//using System;

//class Person
//{
//    public string Name { get; } 
//    private int _age;

//    public int Age
//    {
//        get => _age;
//        set => _age = (value >= 0 && value <= 120) ? value : throw new ArgumentException("Age must be 0-120");
//    }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age; 
//    }

//    public void Greet() => Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
//}


//class Program
//{
//    static void Main()
//    {
//        var p = new Person("Alice", 17);
//        p.Greet();

//        try { p.Age = 200; }
//        catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
//    }
//}



//class BankAccount
//{
//    public string Owner { get; }

//    public decimal Balance { get; private set; }

//    public BankAccount(string owner, decimal initialDeposit)
//    {
//        if (initialDeposit < 0) throw new ArgumentException("Initial deposit cannot be negative");
//        Owner = owner;
//        Balance = initialDeposit;
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount <= 0) throw new ArgumentException("Deposit must be positive");
//        Balance += amount;
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount <= 0) throw new ArgumentException("Withdrawal must be positive");
//        if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
//        Balance -= amount;
//    }

//    public void PrintStatement() => Console.WriteLine($"{Owner}'s balance: ${Balance}");
//}

//class Program
//{
//    static void Main()
//    {
//        var acc = new BankAccount("John Doe", 100m);
//        acc.Deposit(50m);
//        acc.Withdraw(30m);
//        acc.PrintStatement();


//        try { acc.Withdraw(1000m); }
//        catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }



//    }
//}







//240426

//using System.ComponentModel.DataAnnotations;

//Student Aru = new Student { Name = "Nurda", Email = "nurda@mail.com",GPA = 4.01};
//Aru.Greet();

//class Person
//{
//    public string Name { get; set; }
//    public string Email { get; set; }

//    public void Greet() =>
//        Console.WriteLine($"Hi, I'm {Name}.");
//}

//class Student : Person       // Student "is-a" Person
//{
//    public double GPA { get; set; }
//}

//class Teacher : Person       // Teacher "is-a" Person
//{
//    public string Subject { get; set; }
//}



//240426 2
//class Person
//{
//    public string Name { get; set; }

//    public string email { get; set;  }
//    // constructor
//    public Person(string name, string email)
//    {
//        name = name;
//        this.email = email;
//    }
//    public virtual void Greet() =>
//        Console.WriteLine($"Hi, I'm {Name}.");
//}

//class Teacher : Person
//{
//    public string Subject { get; set; }
//    // const suda inherits from person
//    public Teacher(string name, string email, string subject) : base(name, email)
//    {
//        Name = name;
//        this.email = email;
//        Subject = subject;
//    }
//    public override void Greet() =>
//        Console.WriteLine($"Hi, I'm {Name}, I teach {Subject}.");

//    public override void WriteOnEmail()
//    {
//        base.WriteOnEmail();
//    }

//}






//240226 3

//using System;

//class Animal
//{
//    public string Name; 

//    public virtual void Speak()
//    {
//        Console.WriteLine("some sound");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine(Name + " says: Woof!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine(Name + " says: Meow!");
//    }
//}

//class Cow : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine(Name + " says: Moo!");
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Animal[] animals = new Animal[3];

//        animals[0] = new Dog() { Name = "Шарик" };
//        animals[1] = new Cat() { Name = "Мурка" };
//        animals[2] = new Cow() { Name = "Бурёнка" };


//        foreach (Animal a in animals)
//        {
//            a.Speak();
//        }
//    }
//}





//using System;

//class Student
//{
//    public string Name;
//    public int Grade1;
//    public int Grade2;
//    public int Grade3;

//    public double GetAverage()
//    {
//        return (Grade1 + Grade2 + Grade3) / 3.0;
//    }

//    public string GetLetterGrade()
//    {
//        double avg = GetAverage();
//        if (avg >= 90) return "A";
//        if (avg >= 75) return "B";
//        if (avg >= 60) return "C";
//        return "F";
//    }

//    public void Print()
//    {
//        Console.WriteLine(Name + " | Average: " + GetAverage() + " | Grade: " + GetLetterGrade());
//    }
//}

//class BankAccount
//{
//    public string Owner { get; }
//    public decimal Balance { get; private set; }

//    public BankAccount(string owner, decimal initialDeposit)
//    {
//        if (initialDeposit < 0) throw new ArgumentException("Negative deposit");
//        Owner = owner;
//        Balance = initialDeposit;
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount > 0) Balance = Balance + amount;
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
//        if (amount > 0) Balance = Balance - amount;
//    }

//    public void PrintStatement()
//    {
//        Console.WriteLine("Owner: " + Owner + " | Balance: " + Balance);
//    }
//}

//class Temperature
//{
//    private double _celsius;

//    public double Celsius
//    {
//        get { return _celsius; }
//        set
//        {
//            if (value < -273.15) throw new Exception("Error");
//            _celsius = value;
//        }
//    }

//    public double Fahrenheit
//    {
//        get { return _celsius * 9 / 5 + 32; }
//        set { Celsius = (value - 32) * 5 / 9; }
//    }

//    public Temperature(double c)
//    {
//        Celsius = c;
//    }

//    public void Print()
//    {
//        Console.WriteLine(Celsius + "°C / " + Fahrenheit + "°F");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student[] roster = new Student[4];
//        roster[0] = new Student { Name = "Alice", Grade1 = 95, Grade2 = 88, Grade3 = 92 };
//        roster[1] = new Student { Name = "Bob", Grade1 = 70, Grade2 = 65, Grade3 = 80 };
//        roster[2] = new Student { Name = "Charlie", Grade1 = 50, Grade2 = 60, Grade3 = 55 };
//        roster[3] = new Student { Name = "Diana", Grade1 = 85, Grade2 = 90, Grade3 = 88 };

//        for (int i = 0; i < roster.Length; i++)
//        {
//            roster[i].Print();
//        }

//        Student best = roster[0];
//        for (int i = 1; i < roster.Length; i++)
//        {
//            if (roster[i].GetAverage() > best.GetAverage()) best = roster[i];
//        }
//        Console.WriteLine("Best student: " + best.Name);

//        Console.WriteLine("----------------------");

//        BankAccount acc = new BankAccount("John", 100m);
//        acc.Deposit(50m);
//        acc.Withdraw(30m);
//        acc.PrintStatement();

//        try { acc.Withdraw(1000m); } catch (Exception e) { Console.WriteLine(e.Message); }

//        Console.WriteLine("----------------------");

//        Temperature t = new Temperature(25);
//        t.Print();
//        t.Fahrenheit = 100;
//        t.Print();

//        try { t.Celsius = -300; } catch (Exception e) { Console.WriteLine(e.Message); }
//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRegistry
{
    public class Student
    {
        private static int _counter = 1;
        private double _gpa;

        public string Name { get; set; }
        public int StudentId { get; private set; }
        public string Faculty { get; set; }

        public double GPA
        {
            get => _gpa;
            set
            {
                if (value >= 0.0 && value <= 4.0) _gpa = value;
                else throw new Exception();
            }
        }

        public Student(string name, double gpa, string faculty)
        {
            StudentId = _counter++;
            Name = name;
            GPA = gpa;
            Faculty = faculty;
        }

        public override string ToString() =>
            $"ID: {StudentId} | {Name} | Факультет: {Faculty} | GPA: {GPA}";
    }

    public class Registry
    {
        private Student[] _students = new Student[100];
        private int _count = 0;

        public bool Add(Student s)
        {
            if (_count >= 100) return false;
            _students[_count++] = s;
            return true;
        }

        public Student FindById(int id)
        {
            for (int i = 0; i < _count; i++)
                if (_students[i].StudentId == id) return _students[i];
            return null;
        }

        public void FindByName(string name)
        {
            for (int i = 0; i < _count; i++)
                if (_students[i].Name.ToLower().Contains(name.ToLower()))
                    Console.WriteLine(_students[i]);
        }

        public void GetTopStudents(int n)
        {
            var top = _students.Take(_count).OrderByDescending(s => s.GPA).Take(n);
            foreach (var s in top) Console.WriteLine(s);
        }

        public void PrintAll()
        {
            if (_count == 0) Console.WriteLine("Пусто");
            for (int i = 0; i < _count; i++) Console.WriteLine(_students[i]);
        }
    }

    class Program
    {
        static void Main()
        {
            Registry registry = new Registry();
            while (true)
            {
                Console.WriteLine("\n1. Добавить 2. По ID 3. По имени 4. Топ 5. Все 6. Выход");
                string choice = Console.ReadLine();

                if (choice == "6") break;

                try
                {
                    if (choice == "1")
                    {
                        Console.Write("Имя: "); string n = Console.ReadLine();
                        Console.Write("Факультет: "); string f = Console.ReadLine();
                        Console.Write("GPA: "); double g = double.Parse(Console.ReadLine());
                        registry.Add(new Student(n, g, f));
                    }
                    else if (choice == "2")
                    {
                        Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                        var s = registry.FindById(id);
                        Console.WriteLine(s?.ToString() ?? "Не найден");
                    }
                    else if (choice == "3")
                    {
                        Console.Write("Имя: ");
                        registry.FindByName(Console.ReadLine());
                    }
                    else if (choice == "4")
                    {
                        Console.Write("Количество: "); int n = int.Parse(Console.ReadLine());
                        registry.GetTopStudents(n);
                    }
                    else if (choice == "5")
                    {
                        registry.PrintAll();
                    }
                }
                catch { Console.WriteLine("Ошибка ввода!"); }
            }
        }
    }
}
