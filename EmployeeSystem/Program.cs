using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 직원 급여 시스템 ===\n");

Manager manager = new Manager("김부장", 5000000, 1000000);
Developer developer = new Developer("이개발", 4000000, 10);
Intern intern = new Intern("박인턴");

manager.PrintInfo();
developer.PrintInfo();
intern.PrintInfo();
