using System;

public class Hijo : Persona{

    public void jugar(){
        Console.WriteLine("No necesito dormir");
        Console.WriteLine("... mucho tiempo despues");
    }

    //Sobrecarga
    public Hijo(){
        this.name = "Sarina";
        this.age = 27;
    }

    public Hijo(string name, int age){
        this.name = name;
        this.age = age;
    }

    //Sobrecarga de operadores
    public void sumarEdad(int extra){
        this.age = this.age + extra;
        Console.WriteLine("La nueva edad es: " + this.age);
        //this.age += extra;
    }
}