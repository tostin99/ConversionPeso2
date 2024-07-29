namespace API_Pesos.Models
{
    public class WeightParameters
    {
        public double Peso { get; set; }
        public required string FromUnit { get; set; }

        public required string ToUnit { get; set; }

        public double ConvertedWeight { get; set; }

        public string? OutputMessage { get; set; }





    }
}
