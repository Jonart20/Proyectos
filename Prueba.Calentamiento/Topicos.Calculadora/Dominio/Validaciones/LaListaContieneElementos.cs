using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.Calculadora.Dominio.Validaciones
{
    public class LaListaContieneElementos
    {
    }

    public class RealizarValidaciones
    {
        public bool LaListaContieneElementos(IEnumerable<double> laLista)
        {
            return (laLista.Count() > 0);
        }

        public bool LaListaNoContieneElementos(IEnumerable<double> laLista)
        {
            return (!LaListaContieneElementos(laLista));
        }
    }

    
}