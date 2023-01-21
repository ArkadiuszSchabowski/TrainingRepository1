using System;

bool x1;
bool x2;

Console.WriteLine("Czy to prawda, że świnka morska była w przeszłości nazywana nadmorską? Wpisz true lub false");
Console.WriteLine("Czy to prawda, że świnka morska powinna cały czas mieć dostęp do siana? Wpisz true lub false");

Boolean.TryParse(Console.ReadLine()), out x1;
Boolean.TryParse(Console.ReadLine(), out x2);

if (x1 == x2)
{
    Console.WriteLine("Brawo.Obie odpowiedzi są poprawne, przechodzisz dalej");

    Console.WriteLine("Quiz na znajomość świnek morskich");
    Console.WriteLine("Pytanie nr.1. Na czym może ścierać zęby świnka morska");
    Console.WriteLine("A-Banan");
    Console.WriteLine("B-Ogórek");
    Console.WriteLine("C-Siano");
    Console.WriteLine("D-Jabłko");
}
else
{
    Console.WriteLine("Twoja wiedza o świnkach wymaga powtórki");
}