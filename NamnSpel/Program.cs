using System;
bool Answer = true;

while (Answer == true)
{
    Logic.Cleanstuff();
    Logic.Start();
    Logic.DoingStuff();
    Console.ReadLine();
    Answer = Logic.PlayAgain();
}