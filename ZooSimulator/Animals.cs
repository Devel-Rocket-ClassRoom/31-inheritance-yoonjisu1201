using System;
using System.Collections.Generic;
using System.Text;

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "으르렁!")
    {
    }
    public void Hunt()
    {
        Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
    }
}
class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "뿌우!")
    {
    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}
class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age, "꽥꽥!")
    {
    }
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}
