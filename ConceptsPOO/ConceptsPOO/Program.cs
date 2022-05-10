// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2022,14,18));

}
catch (Exception error)
{
    Console.WriteLine(error.Message); ;
}
