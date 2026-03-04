using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
    protected string _name;
    protected int _baseSalary;
    protected string _title;

    public Employee(string name, int baseSalary, string title)
    {
        _name = name;
        _baseSalary = baseSalary;
        _title = title;
    }

    public string GetNmae()
    {
        return _name;
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public int CalculatePay()
    {
        return _baseSalary;
    }

    public void PrintInfo()
    {

        Console.WriteLine($"[{_title}] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:#,###}원");
        Console.WriteLine($"총 급여: {_baseSalary:#,###}원");
        Console.WriteLine();
    }
}
