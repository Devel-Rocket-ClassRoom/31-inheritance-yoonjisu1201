using System;

// README.md를 읽고 코드를 작성하세요.
Animal[] animals =
{
    new Lion("시바", 5),
    new Elephant("덤보", 10),
    new Penguin("뽀로로", 3)
};

Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===\n");
Console.WriteLine("[동물 정보]");
animals[0].DisplayInfo();
animals[1].DisplayInfo();
animals[2].DisplayInfo();

Console.WriteLine("\n[동물 소리]");
animals[0].MakeSound();
animals[1].MakeSound();
animals[2].MakeSound();

Console.WriteLine("\n[동물 행동]");
Lion lion = animals[0] as Lion;
if (lion != null)
{
    lion.Eat();
    lion.Hunt();
}

Elephant elephant = animals[1] as Elephant;
if (elephant != null)
{
    elephant.Eat();
    elephant.SprayWater();
}

Penguin penguin = animals[2] as Penguin;
if (penguin != null)
{
    penguin.Eat();
    penguin.Swim();
}


