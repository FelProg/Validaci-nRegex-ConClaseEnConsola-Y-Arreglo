using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace NombreDePersonas
{
    //Hacer una aplicación en C# de consola, donde se solicite ingresar nombre
    //de 10 personas, al terminar de ingresar esas 10 personas, debe de mostrar
    //una lista con los nombres ingresados.

    //realizada con enfoque a clases.
    class Program
    {

        static void Main(string[] args)
        {
            Herramientas prueba = new Herramientas(); //instancia de Herramientas (clase personalizada)
            string[] listaDePersonas = new string[10]; //arreglo de personas

            listaDePersonas = prueba.Caputura("personas", 10); //pasa los argumentos de tipo de dato y cantidad
                                                               //de datos a capturar.

            //Despliega los datos utilizando los argumentos arreglo,mensaje personalizado y color
            prueba.Desplegar(listaDePersonas, "\n\tLa lista de personas capturadas es la siguiente: \n",ConsoleColor.Blue);

        }

            
    }
}
