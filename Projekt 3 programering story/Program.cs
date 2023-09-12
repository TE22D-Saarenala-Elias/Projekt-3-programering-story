Console.WriteLine("Skriv ditt namn");
string name = Console.ReadLine().ToLower();


if (name == "elias" || name == "wiggo" || name == "micke" )
{
Console.WriteLine("Välkommen");
}
else{
    Console.WriteLine("hejdå, tryck på enter för att stänga ner programmet");
}
if (name == "elias" || name == "wiggo" )
{
Console.WriteLine("spelet kan börja\n" + name + " kom ut ur tunnelbanestationen St.eriksplan och har brottom." + "\nVill du springa till skolan eller ta en hoj?");
string val_1 = Console.ReadLine().ToLower();
if ( val_1 == "springa" || val_1 == "springa till skolan")
{
    Console.WriteLine( "\n" + name + " väljer att springa och och stöter på en hund i parken\n"+ "\nVäljer du att klappa hunden eller att fortsätta att springa?"  );
    string val_2_a = Console.ReadLine().ToLower();
    if (val_2_a == "klappa" || val_2_a == "klappa hunden"){
        Console.WriteLine( name + " väljer att klappa hunden och kommer på att han troligtvis kommer komma försent" + "\n\nGAME OVER" );
    }
     if (val_2_a == "springa" || val_2_a == "springa till skolan"){
        Console.WriteLine( name + " väljer att springa till skolan och hinner i tid\n" + "\nDu vann" );
    }
}
if (val_1== "hoj" || val_1== "ta en hoj"){
    Console.WriteLine( name + " tog hojen och började åka." + "\n du lägger märke till en hund längre fram. Vill du stanna och klappa hunden eller [köra förbi] den?" );
    string val_2_b = Console.ReadLine().ToLower();
    if (val_2_b == "stanna och klappa hunden" || val_2_b == "klappa hunden"){
        Console.WriteLine( name + " stannar och klappar hunden och kommer på att han troligtvis kommer komma försent" + "\n\nGAME OVER" );
    }
    
    if (val_2_b == "köra förbi den" || val_2_b == "köra förbi"){
        Console.WriteLine( name + " väljer att köra förbi den och hinner till skolan i tid\n" + "\nDu vann" );
    }

}


}
//if (){

//}








Console.ReadLine();