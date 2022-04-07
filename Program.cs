﻿// See https://aka.ms/new-console-template for more information
/*
      This program ...Mad Lib
      Author: ...Meredith Jones
      */


Console.WriteLine("Your Mad Lib starts now");

string title = "Wacky Town";

Console.WriteLine(title);

Console.Write("Enter a name: ");
string name = Console.ReadLine();
Console.Write("I need an adjective: ");
string adj1 = Console.ReadLine();
Console.Write("Now another adjective: ");
string adj2 = Console.ReadLine();
Console.Write("One more adjective: ");
string adj3 = Console.ReadLine();
Console.Write("Lets get a verb: ");
string verb = Console.ReadLine();
Console.Write("I need a noun: ");
string noun1 = Console.ReadLine();
Console.Write("One more noun: ");
string noun2 = Console.ReadLine();
Console.Write("Name an animal: ");
string animal = Console.ReadLine();
Console.Write("Name a food: ");
string food = Console.ReadLine();
Console.Write("Now name a fruit: ");
string fruit = Console.ReadLine();
Console.Write("Name a superhero: ");
string superhero = Console.ReadLine();
Console.Write("Name a country: ");
string country = Console.ReadLine();
Console.Write("Name a dessert: ");
string dessert = Console.ReadLine();
Console.Write("Pick a year: ");
string year = Console.ReadLine();


// The template for the story:

string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


// Print the story:
Console.WriteLine(story);

