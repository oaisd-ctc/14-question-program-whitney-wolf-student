using System;

class Program {
    public static void Main (string[] args)
    {
        Console.WriteLine("Firstname:");
        string firstName = Console.ReadLine()!;

        Console.WriteLine("Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Eye Color:");
        string eyeColor = Console.ReadLine()!;

        Console.WriteLine("Hair Color:");
        string hairColor = Console.ReadLine()!;

        Console.WriteLine("Shoe Size:");
        int shoeSize = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Favorite Color:");
        string favoriteColor = Console.ReadLine()!;

        Console.WriteLine("Favorite Movie/TV Show:");
        string favoriteFilm = Console.ReadLine()!;

        Console.WriteLine("Favorite Teacher:");
        string favoriteTeacher = Console.ReadLine()!;

        Console.WriteLine("Favorite Class:");
        string favoriteClass = Console.ReadLine()!;

        Console.WriteLine("Favorite Holiday:");
        string favoriteHoliday = Console.ReadLine()!;

        Console.WriteLine("Favorite Season:");
        string favoriteSeason = Console.ReadLine()!;

        Console.WriteLine("Your Dream Job:");
        string dreamJob = Console.ReadLine()!;

        int ageInput = age;
        int years = 5;

        int sum = ageInput + years;
        Console.WriteLine("Your age in five years will be: " + sum);

        Console.WriteLine("Number of Siblings:");
        int siblings = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("My friends name is " + firstName + ". " + firstName + " is " + age + " years old. " + firstName + "'s eye color is " + eyeColor + ". " 
        + firstName + " also has " + hairColor + " hair and a shoe size of " + shoeSize + ". " + firstName + " has many favorite things, including the color " 
        + favoriteColor + ", the film " + favoriteFilm + ", " + favoriteTeacher + ", " + favoriteClass + " class, " + favoriteHoliday + ", and " + favoriteSeason + ". "
        + firstName + " has a dream job of " + dreamJob + ". In 5 years, " + firstName + " will be " + sum + " years old. " + firstName + " has " + siblings + " siblings.");
    }
}
