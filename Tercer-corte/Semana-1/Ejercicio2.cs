using System;
using System.Collections; 


namespace Ejercicio2 
{
 public class Ejercicio2
 {
    public static void Main()
    {

        
        string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
        Console.WriteLine("La fecha actual es {0}", fechaActual);

        Console.WriteLine("Digite una fecha anterior a hoy");
        DateTime fechaUsuario = DateTime.Parse(Console.ReadLine());
        string fechaDigitada = DateTime.Now.ToString("dd-MM-yyyy");

        DateTime fechaSistema = Convert.ToDateTime(fechaActual);


        if (fechaUsuario > fechaSistema)
        {
            Console.WriteLine("La fecha debe ser menor a hoy");

        }
        else
        {
          
            TimeSpan difFechas = fechaSistema - fechaUsuario;
            int dias = difFechas.Days;
            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} dias  ", fechaDigitada, fechaActual, dias);

            
            float meses = dias / 30;
            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} meses  ", fechaDigitada, fechaActual, meses);

            
            float años = dias / 365;
            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} años  ", fechaDigitada, fechaActual, años);
        }
     }
  }
}