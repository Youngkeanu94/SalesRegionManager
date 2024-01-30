using System.Collections;

string[,] salesRegions;
salesRegions = new string [4, 4];

salesRegions[0, 0] = "North";
salesRegions[1, 0] = "South";
salesRegions[2, 0] = "East";
salesRegions[3, 0] = "West";


salesRegions[0, 1] = "Bob";
salesRegions[0, 2] = "Stef";
salesRegions[0, 3] = "Ron";

salesRegions[1, 1] = "Sue";
salesRegions[1, 2] = "Janice";
salesRegions[1, 3] = "Will";

salesRegions[2, 1] = "Henry";
salesRegions[2, 2] = "Nathan";
salesRegions[2, 3] = "Kimmy";

salesRegions[3, 1] = "Wanda";
salesRegions[3, 2] = "Charles";
salesRegions[3, 3] = "Pete";

Console.WriteLine("Section 1: Two-dimensional Array.");

for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    { 
    Console.WriteLine(salesRegions[row, col]);
    }
Console.WriteLine("");
}
ArrayList salesTeam = new ArrayList();

for (int col = 1; col < 4; col++)
{
    salesTeam.Add(salesRegions[0, col]);
}
Console.WriteLine("Section 2: Array List.");
Console.WriteLine("");

Console.Write("There are " + salesTeam.Count.ToString() + "names in the salesTeam arraylist.");

for (int col = 1; col <4; col++)
{
    salesTeam.Add(salesRegions[1, col]);
}
Console.WriteLine("");

if (salesTeam.Contains("Stef"))
{
    System.Console.WriteLine("Stef is in the salesTeam arraylist.");
}
else
{
    System.Console.WriteLine("Stef is not in the salesTeam arraylist.");
}
Console.WriteLine("There are " + salesTeam.Count.ToString() + " names in the salesTeam arraylist. ");

salesTeam.Remove("Janice");
salesTeam.Remove("Ron");

Console.WriteLine("There are " + salesTeam.Count.ToString() + " names in the salesTeam arrayList. ");
Console.WriteLine("Names currently in the salesTeam arraylist");

for (int i = 0; i < salesTeam.Count; i++)
{
    Console.WriteLine(salesTeam[i]);
}
Console.Read();
