// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pasta", "Pizza", "Deliziosa", "Salmone" , "Spigola", "Polpo", "Cozze", "Vongole", "Lupini", "Platessa" };

var lungLista = cibiPreferiti.Length;

Console.WriteLine("La lunghezza della lista è: " + lungLista + "\n");

for(int i = 0; i < lungLista; i++)
{
    Console.WriteLine($"{cibiPreferiti[i]} - {(i + 1)}");
}

Console.WriteLine($"\nTop cibo preferito: {cibiPreferiti[0]}");
Console.WriteLine($"Ultimo cibo preferito: {cibiPreferiti[lungLista - 1]} ");

if(lungLista % 2 == 0)
{
    Console.WriteLine($"Cibi medio preferiti:  {cibiPreferiti[lungLista /2]} -  {cibiPreferiti[lungLista /2 - 1]}");
}
else
{
    Console.WriteLine($"Cibo medio preferito: {cibiPreferiti[lungLista / 2]}");
}
