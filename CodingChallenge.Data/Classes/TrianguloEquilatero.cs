using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica, IFormaGeometricaOperation
    {
        private readonly decimal _lado;
        public TrianguloEquilatero(int tipo, decimal ancho) : base(tipo, ancho)
        {
            _lado = ancho;
        }
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
        public static string TraducirFormaES(int cantidad)
        {
            return TraducirForma(cantidad, 
                Constants.ES_TRIANGULO_EQUILATERO_SINGULAR, 
                Constants.ES_TRIANGULO_EQUILATERO_PLURAL);
        }

        public static string TraducirFormaEN(int cantidad)
        {
            return TraducirForma(cantidad, 
                Constants.EN_TRIANGULO_EQUILATERO_SINGULAR, 
                Constants.EN_TRIANGULO_EQUILATERO_PLURAL);
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
