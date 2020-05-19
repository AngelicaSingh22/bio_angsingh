namespace CodingChallenge.Data.Classes
{
    public interface IFormaTrapecioOperation
    {
        decimal CalcularArea(decimal baseMayor, decimal baseMenor, decimal altura);
        
        decimal CalcularPerimetro(decimal a, decimal b, decimal c, decimal d);
        
    }
}