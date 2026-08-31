// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

KlasseRum minKlasse = new KlasseRum();
minKlasse.KlasseNavn = "3B";
minKlasse.SemesterStart = new DateTime(2022, 9, 1);
minKlasse.Klasseliste.Add(new Studerende("Christian", 5, 12));
minKlasse.Klasseliste.Add(new Studerende("Rasmus", 7, 31));
minKlasse.Klasseliste.Add(new Studerende("Søren", 4, 26));

Console.WriteLine($"Klassenavn: {minKlasse.KlasseNavn}");
Console.WriteLine($"Semester start: {minKlasse.SemesterStart}");

Console.WriteLine();

Console.WriteLine("Studerende i klassen:");
foreach (var studerende in minKlasse.Klasseliste)
{
    Console.WriteLine($"- {studerende.Navn} (fødselsdag: {studerende.Fødselsdag}/{studerende.Fødsesldagsmåned})");
}