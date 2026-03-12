using System;

var basic = new 
{ 
    ResolutionWidth = 1920, 
    ResolutionHeight = 1080, 
    Volume = 50, 
    Difficulty = "보통" 
};
var custom = new
{
    ResolutionWidth = 1920,
    ResolutionHeight = 1080,
    Volume = 80,
    Difficulty = "어려움"
};

Console.WriteLine("=== 게임 설정 비교 ===");
Console.WriteLine();
Console.WriteLine($"[기본 설정]\n{basic.ToString()}\n");
Console.WriteLine($"[사용자 설정]\n{custom.ToString()}\n");
Console.WriteLine($"[타입 비교]\n같은 타입: {basic.GetType() == custom.GetType()}\n");
Console.WriteLine($"[값 비교]\nEquals 결과: {basic.Equals(custom)} (Volume, Difficulty 값이 다름)\n");
var backUp = new
{
    ResolutionWidth = 1920,
    ResolutionHeight = 1080,
    Volume = 50,
    Difficulty = "보통"
};
Console.WriteLine($"[백업 설정]\n{backUp.ToString()}\n기본 설정과 Equals: {basic.Equals(backUp)} (모든 값이 동일)");
Console.WriteLine("\n=== 설정 목록 (배열) ===");
var array = new[]
{
    basic, custom, backUp
};
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"설정 {i+1}: {array[i]}");
}
Console.WriteLine();
Console.WriteLine("=== 속성 순서가 다른 설정 ===");

var diff = new
{
    Volume = 50,
    Difficulty = "보통",
    ResolutionWidth = 1920,
    ResolutionHeight = 1080
};
Console.WriteLine(diff);
Console.WriteLine($"기본 설정과 같은 타입: {basic.GetType() == diff.GetType()} (속성 순서가 달라 다른 타입)");