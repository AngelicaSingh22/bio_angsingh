namespace CodingChallenge.Data.Classes
{
    public class Trapecio : IFormaTrapecioOperation
    {
        public decimal CalcularArea(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            return ((baseMayor + baseMenor) * altura) / 2;
        }

        public decimal CalcularPerimetro(decimal a, decimal b, decimal c, decimal d)
        {
            return a + b + c + d;
        }
    }
}
