using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
///* 
            //Herencia
            Hijo h1 = new Hijo();
            h1.jugar();
            h1.dormir();
//*/

/*
            //Polimorfismo
            Padre p1 = new Padre();
            p1.dormir();
            h1.elObjetoEs();
            Console.WriteLine(p1.ToString());
*/

/* 
            //Sobrecarga de métodos
            Hijo h2 = new Hijo();
            Hijo h3 = new Hijo("Armando", 25);

            //Sobrecarga de operadores
            h2.sumarEdad(24);
            h3.sumarEdad(2);
*/
        }
    }
}
