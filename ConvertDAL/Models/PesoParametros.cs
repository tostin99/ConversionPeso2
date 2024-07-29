using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDAL.Models
{
    /// <summary>
    /// Clase que representa los parámetros necesarios para realizar una conversión de peso.
    /// </summary>
    public class PesoParametros
    {
        /// <summary>
        /// Peso que se va a convertir.
        /// </summary>
        private double peso;
        /// <summary>
        /// Valor resultante de la conversión de peso.
        /// </summary>
        private double convertidorPeso;
        /// <summary>
        /// Unidad de medida a la cual se va a realizar la conversión.
        /// </summary>
        private string fromUnit;
    
        private string toUnit;
        /// <summary>
        /// Mensaje de salida que describe la conversión realizada.
        /// </summary>
        private string mensaje;

        public double ConvertidorPeso { get => convertidorPeso; set => convertidorPeso = value; }
        public string FromUnit { get => fromUnit; set => fromUnit = value; }
        public string ToUnit { get => toUnit; set => toUnit = value; }
        public string OutputMessage { get => mensaje; set => mensaje = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}
