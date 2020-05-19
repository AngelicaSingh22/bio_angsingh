using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica, IFormaGeometricaOperation
    {
        private readonly decimal _lado;
        public Circulo(int tipo, decimal ancho) : base(tipo, ancho)
        {
            _lado = ancho;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
        public static string TraducirFormaES(int cantidad)
        {
            return TraducirForma(cantidad, Constants.ES_CIRCULO_SINGULAR, Constants.ES_CIRCULO_PLURAL);
        }

        public static string TraducirFormaEN(int cantidad)
        {
            return TraducirForma(cantidad, Constants.EN_CIRCULO_SINGULAR, Constants.EN_CIRCULO_PLURAL);
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

        //private static string TraducirForma(int cantidad, string textoSingular, string textoPlural)
        //{
        //    return cantidad == 1 ? textoSingular : textoPlural;
        //}
    }
}
