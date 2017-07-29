using System;

public class Persona {
    protected string name;
    public int age;

    public virtual void dormir(){
        Console.WriteLine("Necesito dormir 8 horas!");
    }

    public void elObjetoEs(){
        Console.WriteLine("El objeto enviado es " + this.ToString());
    }
  
/*
    public override string ToString() 
    {
        return "Sobreescribiendo el método ToString";
    }
*/
}