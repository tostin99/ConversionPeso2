using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDAL.DAL
{
    public class PesoDAL
    {
        private Dictionary<string, Func<double, double>> conversionMap;
        /// <summary>
        /// Constructor de la clase PesoDAL. Inicia el mapeo de conversiones.
        /// </summary>
        public PesoDAL()
        {
            IniciarMapeo();
        }
        /// <summary>
        /// Inicializa el mapeo de conversiones entre unidades de peso.
        /// </summary>
        private void IniciarMapeo()
        {
            conversionMap = new Dictionary<string, Func<double, double>>
                {
                    {"KtoL", ConvertKilogramosToLibras },
                    {"KtoO", ConvertKilogramosToOnzas },
                    {"LtoK", ConvertLibrasToKilogramos },
                    {"LtoO", ConvertLibrasToOnzas},
                    {"OtoK", ConvertOnzasToKilogramos },
                    {"OtoL", ConvertOnzasToLibras },
                };
        }
        // Métodos de conversión de unidades de peso
        #region Conversiones
        /// <summary>
        /// Convierte kilogramos a libras.
        /// </summary>
        private double ConvertKilogramosToLibras(double kilogramos) => (kilogramos * 1 * 2.20);

        /// <summary>
        /// Convierte kilogramos a onzas.
        /// </summary>
        private double ConvertKilogramosToOnzas(double kilogramos) => kilogramos * 35.27 ;
        /// <summary>
        /// Convierte libras a kilogramos.
        /// </summary>
        private double ConvertLibrasToKilogramos(double libras) => (libras * 0.45);
        /// <summary>
        /// Convierte libras a onzas.
        /// </summary>
        private double ConvertLibrasToOnzas(double libras) => (libras * 16 ) ;
        /// <summary>
        /// Convierte onzas a kilogramos.
        /// </summary>
        private double ConvertOnzasToKilogramos(double onzas) => onzas * 0.029 ;
        /// <summary>
        /// Convierte onzas a libras.
        /// </summary
        private double ConvertOnzasToLibras(double onzas) => (onzas *0.06 );

        #endregion

        /// <summary>
        /// Obtiene la función de conversión correspondiente a la clave proporcionada.
        /// </summary>
        /// <param name="key">Clave que identifica la conversión deseada.</param>
        /// <returns>Función de conversión.</returns>
        /// <exception cref="InvalidOperationException">Se lanza cuando la conversión no es soportada.</exception>
        public Func<double, double> GetConversionFunction(string key)
        {
            if (conversionMap.TryGetValue(key, out Func<double, double> conversion))
            {
                return conversion;
            }
            throw new InvalidOperationException("Conversion no soportada.");
        }
    }
}
