using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    protected string _sound;
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string sound, string name, int age)
    {
        _sound = sound;
        Name = name;
        Age = age;
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


class Lion : Animal
{
    public Lion(string sound, string name, int age) : base(sound, name, age)
    {
    }

    public void Hunt() => Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
}

class Elephant : Animal
{

    public void SprayWater() => Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
}

class Penguin : Animal
{

    public void Swim() => Console.WriteLine($"{Name}이(가) 수영을 합니다.");
}