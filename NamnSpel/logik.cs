using System;

public class Logic{
public static string [] names = {"Bowser", "Doctor Robotnik", "King Krool", "Dr Wily", "Sephiroth", "Ganon", "Captain LeChuck", "Alice", "Maja", "Vera", "Alma", "Selma", "Gustafsson", "Svensson", "Johansson", "Noah", "William", "Liam", "Hugo", "Lucas"};
    public static void Start(){
        System.Console.WriteLine("Skriv en sifra mellan 3 och 10 Det får inte vara en bokstav, för att få ett namn med den längden");
    }
    public static void DoingStuff (){
        int nameLength;
        bool check = true;
        while(check == true){
            if(int.TryParse(System.Console.ReadLine(), out nameLength) == true){
                if(nameLength > 3 && nameLength < 10){
                    System.Console.WriteLine("ye");
                }
            }
        }
    }



}