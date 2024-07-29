namespace API_Pesos.Helpers
{
    // Helper para la conversion de pesos
    public static class WeightConversionHelper
    {
        //diccionario con los metodos y llave para la conversion de pesos
        private static readonly Dictionary<string, Func<double, double>> conversionMap = new Dictionary<string, Func<double, double>>
        {
            {"KToL", kg => kg * 2.20462 },
            {"LToK", lb => lb * 0.453592 },
            {"KToO", kg => kg * 35.247 },
            {"OToK", oz => oz * 0.0283495 },
            {"LToO", lb => lb * 16 },
            {"OToL", oz => oz * 0.0625 },
            {"KToT", kg => kg * 0.001 },
            {"TToK", t => t * 1000 }, 
            {"TToTU", t => t * 1.10231 }, 
            {"TUToT", ust => ust * 0.907185 },
            {"TToTK", t => t * 0.984207 }, 
            {"LToT", lb => lb * 0.000453592 }, 
            {"TToL", t => t * 2204.62 }, 
            {"LToTU", lb => lb * 0.0005 }, 
            {"TUToL", ust => ust * 2000 }, 
            {"LToTK", lb => lb * 0.000446429 }, 
            {"TKToL", brt => brt * 2240 }, 
            {"OToTU", oz => oz * 0.000625 }, 
             {"TUToO", ust => ust * 1600 }, 
             {"OToTK", oz => oz * 0.000559524 }, 
             {"TKToO", brt => brt * 1792 }, 
            {"KToTU", kg => kg * 0.00110231 },
            {"TKToTU", brt => brt * 1.12 },
            {"KToTK", kg => kg * 0.000984207 },
            {"OToT", oz => oz * 0.0000283495 },
            {"TToO", t => t * 35274 },
            {"TUToK", ust => ust * 907.185 },
            //{"TUToTK", ust => ust * 0.892857 },
            //{"TKToT", brt => brt * 1.01605 },
            //{"TKToT", brt => brt * 1.01605 }


























        };
        
        public static double ConvertWeight (double peso, string fromUnit, string toUnit)
        {
            string key = $"{fromUnit}To{toUnit}";
            if (conversionMap.TryGetValue(key, out var conversionFunc)) 
            {
                return conversionFunc(peso);
            }
            throw new InvalidOperationException("Operacion no soportada");
        }
        
    } 
}
