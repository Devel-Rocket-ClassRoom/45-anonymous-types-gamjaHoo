using System;

var weathers = new[]
{
    new{day = "월요일", highTemperature = 12, lowTemperature = 3, rainPossibility = 20},
    new{day = "화요일", highTemperature = 8, lowTemperature = -1, rainPossibility = 60},
    new{day = "수요일", highTemperature = 5, lowTemperature = -3, rainPossibility = 80},
    new{day = "목요일", highTemperature = 10, lowTemperature = 2, rainPossibility = 40},
    new{day = "금요일", highTemperature = 15, lowTemperature = 5, rainPossibility = 10}
};

Console.WriteLine("=== 5일간 날씨 예보 ===");
Console.WriteLine("요일     최고기온  최저기온  강수확률");
Console.WriteLine("--------------------------------------");
double avg = 0;
int total = 0;
int count = 0;
foreach(var weather in weathers)
{
    if(weather.rainPossibility > 50)
    {
        count++;
    }
    total += weather.highTemperature;
    Console.WriteLine($"{weather.day}     {weather.highTemperature}          {weather.lowTemperature}       {weather.rainPossibility}%");
}
avg = total / (double)weathers.Length;
Console.WriteLine("--------------------------------------");
Console.WriteLine($"최고기운 평균: {avg:F1}도");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {count}일");