using System;
using System.Globalization;

namespace Agenda_de_Contactos 
{
    class Registro
    {
        // En esta parte se puso los datos  que se van a manejar
        String Nombre { get; set; }
        int Numero { get; set; }
        string Correo {  get; set; }
        // Aqui esta el constructor
        Registro(string nombre, int numero, string correo)
        {
            Nombre = nombre;
            Numero = numero;
            Correo = correo;
        }
        List<Tuple<string, int, string>> listaDeDatos = new List<Tuple<string, int, string>>();
   
    }

}

