using ConvertDAL.DAL;
using ConvertDAL.Models;
using System;



using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBLL.BLL
{
    public  class PesoBLL


    {
        private readonly PesoDAL pesoDAL;

        public PesoBLL()
        {
            pesoDAL = new PesoDAL();
        }
        /// <summary>
        /// Convierte un valor de peso de una unidad a otra.
        /// </summary>
        /// <param name="parametros">Objeto que contiene los parámetros necesarios para la conversión de peso.</param>
        /// <returns>Objeto <see cref="PesoParametros"/> que contiene el resultado de la conversión.</returns>
        public PesoParametros ConvertPeso(PesoParametros parametros)
        {
            // Construir la clave para buscar la función de conversión en la capa de acceso a datos (pesoDAL).
            string key = $"{parametros.FromUnit}to{parametros.ToUnit}";
            // Obtener la función de conversión correspondiente a la clave proporcionada.
            var conversionFunc = pesoDAL.GetConversionFunction(key);
            // Calcular el resultado de la conversión utilizando la función obtenida.
            double result = conversionFunc(parametros.Peso);
            // Construir el mensaje de salida que indica la conversión realizada.
            parametros.OutputMessage = $"{parametros.Peso} {parametros.FromUnit} es igual a {result:0.##} {parametros.ToUnit}";
            // Asignar el resultado de la conversión al campo ConvertidorPeso del objeto PesoParametros.
            parametros.ConvertidorPeso = result;
            // Devolver el objeto PesoParametros actualizado con el resultado de la conversión.
            return parametros;
        }

    }
}
