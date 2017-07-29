using System;

public class Padre : Persona{ 

    public override void dormir(){
        base.dormir();
        Console.WriteLine("Necesito dormir solo 4 hours!");
    }

}