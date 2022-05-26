// See https://aka.ms/new-console-template for more information

using CsvHelper;
using System.Globalization;
using System.Linq;
using System.IO;
using System;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Text;
using ConsoleGUS.Models;
using ConsoleGUS.Repository;
using ConsoleGUS.Services;

Console.WriteLine("Witaj w aplikacji wczytujacej dane z GUS TERC!");
Console.WriteLine("Podaj kod lub symbol");
string liczbaDoPorownania = Console.ReadLine();
DisplayResultSimcService.DisplaySImc(liczbaDoPorownania);
DisplayResultStreetService.DisplayStreet(liczbaDoPorownania);






