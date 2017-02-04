using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Topicos.Calculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CalculadoraVector : ICalculadoraVector
    {

        public double Sumar(IEnumerable<double> laLista)
        {
            Topicos.Calculadora.Dominio.Acciones.Sumar laAccion = new Dominio.Acciones.Sumar();
            return laAccion.RealizarOperacion(laLista);
            //double resultado = laAccion.RealizarOperacion(laLista);
            //return resultado;
        }

        public double Restar(IEnumerable<double> laLista)
        {
            Topicos.Calculadora.Dominio.Acciones.Restar laAccion = new Dominio.Acciones.Restar();
            return laAccion.RealizarOperacion(laLista);
        }

        public double Multiplicar(IEnumerable<double> laLista)
        {
            Topicos.Calculadora.Dominio.Acciones.Multiplicar laAccion = new Dominio.Acciones.Multiplicar();
            return laAccion.RealizarOperacion(laLista);
        }

        public double Dividir(IEnumerable<double> laLista)
        {
            Topicos.Calculadora.Dominio.Acciones.Dividir laAccion = new Dominio.Acciones.Dividir();
            return laAccion.RealizarOperacion(laLista);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
