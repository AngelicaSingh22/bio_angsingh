namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica, IFormaGeometricaOperation
    {
        private readonly decimal b;
        private readonly decimal h;
        private readonly int tipo;

        public Rectangulo(int tipoForma,int bas, decimal alt) : base(tipoForma, bas)
        {
            tipo = tipoForma;
            b = bas;
            h = alt;
        }
        public decimal CalcularArea()
        {
            return b * h;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * b + 2 * h;
        }
        public static string TraducirFormaES(int cantidad)
        {
            return TraducirForma(cantidad, Constants.ES_RECTANGULO_SINGULAR, Constants.ES_RECTANGULO_PLURAL);
        }

        public static string TraducirFormaEN(int cantidad)
        {
            return TraducirForma(cantidad, Constants.EN_RECTANGULO_SINGULAR, Constants.EN_RECTANGULO_PLURAL);
        }
        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == FormaGeometrica.idiomaCastellano)
                    return $"{cantidad} {TraducirFormaES(cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {TraducirFormaEN(cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }
    }
}
