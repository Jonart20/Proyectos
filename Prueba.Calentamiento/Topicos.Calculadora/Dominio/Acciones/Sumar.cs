using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.Calculadora.Dominio.Acciones
{
    public class Sumar
    {
        /// <summary>
        ///realiza la operacion que la clase indica
        /// </summary>
        /// <param name="laLista">la lista de dos elementos que se desea operar</param>
        /// <returns>Resultado de apicar el operador a cada uno de los terminos de la lista</returns>
        public int RealizarOperacion(IEnumerable<double> laLista)
        {
            double elResultado =0;           
            Dominio.Especificaciones.Sume laEspecificacion = new Dominio.Especificaciones.Sume();
            elResultado = laEspecificacion.CalcularResultado(laLista);
            return elResultado;
        }
    }
}