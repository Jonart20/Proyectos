using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.Calculadora.Dominio.Especificaciones
{
    public class Multiplique
    {
        internal double CalcularResultado(IEnumerable<double> laLista)
        {
            double elResultado = 0;
            Dominio.Validaciones.RealizarValidaciones laValidacion = new Dominio.Validaciones.RealizarValidaciones();
            if (laValidacion.LaListaNoContieneElementos(laLista))
                elResultado = 0;
            foreach (var elItemDeLaLista in laLista)
            {
                elResultado *= elItemDeLaLista;
            }
            return elResultado;

        }
    }
}