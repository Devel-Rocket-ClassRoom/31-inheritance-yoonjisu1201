using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    protected string _sound;
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age, string sound)
    {
        Name = name;
        Age = age;
        _sound = sound;
    }
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}