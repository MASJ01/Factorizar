using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad2
{
    public class Recursividad
    {
        int Factorial(int fact) 
        { 
            if (fact > 0) 
        { 
            int valor = fact * Factorial(fact - 1); 
            return valor; 
            } 
            else                
            return 1; 
        } 
 
 
        static void Main(string[] args)
        {
            Recursividad re = new Recursividad(); 
            int f = re.Factorial(6); //Ingresar el valor del numero que deseas su factorial
            Console.WriteLine("El factorial de 6 es " + f); //En el 4 cambiamos el numero ya que sera el numero que sera nuestro numero a factorizar 
            Console.ReadKey();   
        }
    }
}
