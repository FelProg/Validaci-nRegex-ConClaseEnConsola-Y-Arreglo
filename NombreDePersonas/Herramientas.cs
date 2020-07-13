using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions; //necesaria para expresiones regulares.

namespace NombreDePersonas
{
    class Herramientas
    {
        //linea de validación con expresiones regulares aceptando letras, espacios,acentos y puntos.
        Regex condicion = new Regex("^[\\S][a-zA-ZÀ-ÿ\\s\\.]*$");
       
        //devuelve con estructura ternaria verdadero si la entrada coincide con la validación.
        public bool ValidacionLetrasEspaciosAcentos(string paraValidar)
        {
            //si paraValidar es numero,letra,espacio,acento y diferente de vacío devuelve true
            return condicion.IsMatch(paraValidar) && paraValidar != string.Empty ? true : false;
        }

        //Acepta los datos aceptando los parametros de cantidad y tipo de datos a desplegar.
        public string[] Caputura(string paraCapturar, int elem)
        {
            string[] datos = new string[elem];
            for(int i=0; i<datos.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"\n\tIngrese el nombre de {elem-i} {paraCapturar} \n\n");
                Console.Write($"\tPersona {i+1} : ");
                string persona = Console.ReadLine();


                //llama a el metodo "ValidacionLetrasEspaciosAcentos dentro de la misma clase 
                //pasando la captura del usuario para validarla.
                if (this.ValidacionLetrasEspaciosAcentos(persona))
                {
                    datos[i] = persona;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\tDato invalido, presione cualquier tecla para recapturar");
                    Console.ReadKey();
                    Console.ResetColor();
                    i--; //decrementa el valor de i para forzar la captura del mismo elemento.
                }
            }

            return datos; //regresa el arreglo datos.
            
        }

        //despliega la lista de personas con un mensaje personalizado
        public void Desplegar(string[] lista, string mensageParaDesplegar, ConsoleColor color)
        {
            Console.Clear();
            
            Console.WriteLine(mensageParaDesplegar);
            Console.ForegroundColor = color;
            foreach (string elem in lista)
            {
                Console.WriteLine("\t"+elem);
            }
            Console.ResetColor();

            Console.WriteLine("\n\tPresione cualquier tecla para continuar... Gracias!!!");
            Console.ReadKey();
        }

       
        
    }
}
