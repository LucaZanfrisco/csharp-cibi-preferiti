// See https://aka.ms/new-console-template for more information

string[] cibi = { "Pasta", "Pizza", "Deliziosa", "Salmone" , "Spigola", "Polpo", "Cozze", "Vongole", "Lupini", "Platessa" };

Console.WriteLine("La lunghezza della lista è: " + cibi.Length);
Console.WriteLine("-----");

for(int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine(cibi[i] + " - " + (i+1));
}

Console.WriteLine("-----");
Console.WriteLine("Top: " + cibi[0]);
Console.WriteLine("Bottom: " + cibi[cibi.Length - 1]);


if(cibi.Length % 2 == 0)
{
    Console.WriteLine("Middle: " + cibi[cibi.Length/2] + " - " + cibi[cibi.Length/2 - 1]);
}
else
{
    Console.WriteLine("Middle: " + cibi[cibi.Length / 2]);
}
