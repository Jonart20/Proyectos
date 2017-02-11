using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.Calculadora.Dominio.Especificaciones
{
    public class Divide
    {
        internal double CalcularResultado(IEnumerable<double> laLista)
        {
            double elResultado =0;
            Dominio.Validaciones.RealizarValidaciones laValidacion = new Dominio.Validaciones.RealizarValidaciones();
            if (laValidacion.LaListaContieneElementos(laLista))
            {
                elResultado = laLista.First();
                var laListaParaRecorrer = laLista.Skip(1);
                foreach (var elItemDeLaLista in laListaParaRecorrer)
                {
                    elResultado /= elItemDeLaLista;
                }
            }
                
           
            return elResultado;

        }
    }
}