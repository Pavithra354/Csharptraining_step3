using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class RefOutWithClassExample
{
    static void Main()
    {
        // Ref with reference type
        Employee emp1 = new Employee { Id = 1, Name = "Alice" };
        Console.WriteLine($"Before RefMethod: {emp1.Id}, {emp1.Name}");

        RefMethod(ref emp1);
        Console.WriteLine($"After RefMethod: {emp1.Id}, {emp1.Name}");

        // Out with reference type
        Employee emp2;
        OutMethod(out emp2);
        Console.WriteLine($"After OutMethod: {emp2.Id}, {emp2.Name}");
    }

    static void RefMethod(ref Employee emp)
    {
        // Reassign to a new object
        emp = new Employee { Id = 2, Name = "Bob" };
    }

    static void OutMethod(out Employee emp)
    {
        emp = new Employee { Id = 3, Name = "Charlie" };
    }
}