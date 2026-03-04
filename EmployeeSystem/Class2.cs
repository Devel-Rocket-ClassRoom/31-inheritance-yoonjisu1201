using System;
using System.Collections.Generic;
using System.Text;

class Manager : Employee
{
    private int _bonus;


    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary, "매니저")
    {
        _bonus = bonus;
    }

    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[{_title}] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:#,###}원");
        Console.WriteLine($"보너스: {_bonus:#,###}원");
        Console.WriteLine($"총 급여: {CalculatePay():#,###}원");
        Console.WriteLine();
    }
}