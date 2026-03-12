using System;
using System.Threading.Tasks.Sources;

//1
{
    var person = new {name =  "김철수",grade =  3, score = 95.5 };
    Console.WriteLine($"이름: {person.name}\n학년: {person.grade}\n점수: {person.score}");
}

//2-1
{
    string name = "이영희";
    int age = 28;
    var person1 = new {Name = name, Age = age};
    Console.WriteLine($"person1: {person1.Name}, {person1.Age}");
}

//2-2
{
    string name = "이영희";
    int age = 28;
    var person2 = new { name, age };
    Console.WriteLine($"person2: {person2.name}, {person2.age}");
}

//3
{
    string text = "Hello";
    var t = new { text, text.Length };
    Console.WriteLine($"텍스트: {t.text}\n길이: {t.Length}");
}

//4
{
    int price = 25000;
    var product = new { ID = 100, Name = "마우스", price };
    Console.WriteLine($"ID: {product.ID}\n상품명: {product.Name}\n가격: {product.price}\n포맷된 가격: {product.price:N0}");
}

//5
{
    var point1 = new { a = 50, b = 50 };
    var point2 = new { a = 30, b = 40 };
    Console.WriteLine($"같은 타입: {point1.GetType() == point2.GetType()}");
    point1 = point2;
    Console.WriteLine($"point1: ({point1.a}, {point1.b})");
}

//6
{
    var a = new { q = 1, w = 2 };
    var b = new { q = 1, w = 2 };
    var c = new { q = 5, w = 7 };
    Console.WriteLine($"a.Equals(b): {a.Equals(b)}\na.Equals(c): {a.Equals(c)}");
}

//7
{
    var a = new { q = 1, w = 2 };
    var b = new { q = 1, w = 2 };
    var c = a;
    Console.WriteLine($"a == b: {a == b}\na == c: {a == c}");
}

//8
{
    var a = new[]
    {
        new {name = "김철수", score  =85},
        new {name = "이영희", score = 92},
        new {name = "박민수", score = 78}
    };
    Console.WriteLine("=== 학생 점수 목록 ===");
    foreach(var b in a)
    {
        Console.WriteLine($"{b.name}: {b.score}점");
    }
}

//9
{
    var a = new[]
    {
        new {name = "키보드", count = 3, price = 50000},
        new {name = "모니터", count = 5, price = 160000}
    };
    Console.WriteLine($"첫 번째 상품: {a[0].name}\n상품 개수: {a[0].count}");
    int total = 0;
    foreach(var b in a)
    {
        total += b.count * b.price;
    }
    Console.WriteLine($"총 가격: {total:N0}원");
}

//10
{
    var obj = new { Id = 1, Name = "Object 1" };
    Console.WriteLine($"{obj.Id} - {obj.Name}");

    obj = new { Id = 2, Name = "Object 2" };
    Console.WriteLine($"{obj.Id} - {obj.Name}");
}

//11
{
    var anon = new { name = "홍길동", age = 30 };
    var tup = ("홍길동", 30);
    Console.WriteLine($"익명 타입: {anon.name}, {anon.age}\n튜플: {tup.Item1}, {tup.Item2}");
}

//12
{
    var person = new { Name = "김영희", Age = 25, City = "서울" };
    Console.WriteLine($"{person.ToString()}\n{{ Name = {person.Name}, Age = {person.Age}, City = {person.City} }}");
}

//13
{
    var employees = new[]
    {
        new {name = "김철수", team = "개발팀", pay = 5000},
        new {name = "이영희", team = "기획팀", pay = 4500},
        new {name = "박민수", team = "개발팀", pay = 5500}
    };
    Console.WriteLine("=== 직원 정보 ===");
    foreach(var employee in employees)
    {
        Console.WriteLine($"{employee.name} ({employee.team}) - {employee.pay:N0}만원");
    }
}

//14
{
    string[] names = { "사과", "바나나", "오렌지" };
    int[] prices = { 1000, 1500, 2000 };

    var fruits = new[]
    {
    new { Name = names[0], Price = prices[0] },
    new { Name = names[1], Price = prices[1] },
    new { Name = names[2], Price = prices[2] }
};

    Console.WriteLine("=== 과일 가격표 ===");
    foreach (var fruit in fruits)
    {
        Console.WriteLine($"{fruit.Name}: {fruit.Price}원");
    }
}