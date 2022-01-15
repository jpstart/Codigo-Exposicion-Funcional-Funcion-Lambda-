using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Codigo_Exposicion_Funcional__Funcion_Lambda_
{
    class Program
    {
        static void Main(string[] args)
        {
        //Imaginemos el caso que queremos ordenar una lista, usando el método Sort.
        //El método Sort espera un delegate de tipo Comparison,este delegate es un delegate genérico que
        //espera dos argumentos de tipo T, y devuelve un int://

        public delegate int Comparison<T>(T x, T y);
        //Si queremos ordenar una lista, usando un método anónimo, haríamos algo parecido a esto://
        List<string> lista = new List<string>() { "Perro", "Gato", "Zorro" };
        IList.sort(delegate (string s1, string s2);
        { 
        return s1.CompareTo(s2);
        } );
        //Dentro de la llamada del método Sort, creamos el método anónimo(de tipo Comparison<string>).//
        //Bien, pues básicamente las expresiones lambda son una sintaxis alternativa(mucho más compacta), 
        //para hacer exactamente lo mismo.Fijaros como quedaría el código anterior usando expresiones lambda://

        List<string> lista = new List<string>() { "Perro", "Gato", "Zorro" };
        IList.sort((x, y) => x.Compare To(y));

        //Es una sintaxis mucho más compacta que "la clásica" de métodos anónimos//
        //El operador => es el operador lambda, y la sintaxis es param-list => valor_retorno 
        //siendo param-list una lista de parámetros(separados por comas), y 
        //valor_retorno una expresión que se evaluará y será el resultado de la expresión lambda.
        }

    }
}
