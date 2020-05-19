namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IFormaGeometricaOperation
    {
        private readonly decimal _lado;
        public Cuadrado(int tipo, decimal ancho) : base(tipo, ancho)
        {
            _lado = ancho;
        }
        public decimal CalcularArea()
        {
            return _lado * _lado;
        }      

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public static string TraducirFormaES(int cantidad)
        {
            return TraducirForma(cantidad, Constants.ES_CUADRADO_SINGULAR, Constants.ES_CUADRADO_PLURAL);
        }

        public static string TraducirFormaEN(int cantidad)
        {
            return TraducirForma(cantidad, Constants.EN_CUADRADO_SINGULAR, Constants.EN_CUADRADO_PLURAL);
        }

        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == (int)Idiomas.Castellano)
                    return $"{cantidad} {TraducirFormaES(cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {TraducirFormaEN(cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }
    }
}
