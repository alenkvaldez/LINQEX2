using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQEX2;
class Program
{
    static void Main(string[] args)
    {
        var games = new List<string>() { "NBA2K", "COD", "FIGHTNIGHT" };

        var asc = games.OrderBy(games => games.Length);
        foreach (var game in asc)
        {
            Console.WriteLine(game);
        }
    }
}

////Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise
