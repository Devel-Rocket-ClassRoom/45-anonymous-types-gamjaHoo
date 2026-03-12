using System;

string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2014;

var movie = new
{
    title,
    genre,
    rating,
    releaseYear
};

Console.WriteLine($"제목: {movie.title}\n장르: {movie.genre}\n평점: {movie.rating}\n개봉연도: {movie.releaseYear}");
Console.WriteLine("\nToString 결과:");
Console.WriteLine(movie);