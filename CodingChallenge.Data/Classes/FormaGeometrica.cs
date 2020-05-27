using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        private readonly decimal _lado;
        public static readonly int idiomaCastellano = (int)Idiomas.Castellano;
        public static readonly int tipoCuadrado = (int)Form.TipoCuadrado;
        public static readonly int tipoCirculo = (int)Form.TipoCirculo;
        public static readonly int tipotrianguloEquilatero = (int)Form.TipoTrianguloEquilatero;
        public static readonly int tipoRectangulo = (int)Form.TipoRectangulo;
        public static readonly int idiomaIngles = (int)Idiomas.Ingles;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(GetHeader(idioma, Constants.ES_HEADER_EMPTY, Constants.EN_HEADER_EMPTY));
            }
            else
            {
                sb.Append(GetHeader(idioma, Constants.ES_HEADER, Constants.EN_HEADER));
                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroRectangulos= 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaRectangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroRectangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo == tipoCuadrado)
                    {
                        numeroCuadrados++;
                        var cuadrado = ((Cuadrado)formas[i]);
                        areaCuadrados += cuadrado.CalcularArea();
                        perimetroCuadrados += cuadrado.CalcularPerimetro();
                    }
                    if (formas[i].Tipo == tipoCirculo)
                    {
                        numeroCirculos++;
                        var circulo = ((Circulo)formas[i]);
                        areaCirculos += circulo.CalcularArea();
                        perimetroCirculos += circulo.CalcularPerimetro();
                    }
                    if (formas[i].Tipo == tipotrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        var trianguloEquilatero = ((TrianguloEquilatero)formas[i]);
                        areaTriangulos += trianguloEquilatero.CalcularArea();
                        perimetroTriangulos += trianguloEquilatero.CalcularPerimetro();
                    }
                    if (formas[i].Tipo == tipoRectangulo)
                    {
                        numeroRectangulos++;
                        var rectangulo = ((Rectangulo)formas[i]);
                        areaRectangulos += rectangulo.CalcularArea();
                        perimetroRectangulos += rectangulo.CalcularPerimetro();
                    }
                }
                
                sb.Append(Cuadrado.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, idioma));
                sb.Append(Circulo.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, idioma));
                sb.Append(TrianguloEquilatero.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, idioma));
                sb.Append(Rectangulo.ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, idioma));

                // FOOTER
                sb.Append(Constants.TOTAL);

                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroRectangulos + Constants.SPACE_WHITE + 
                    GetIdioma(idioma, Constants.ES_FORMAS, Constants.EN_FORMAS) + Constants.SPACE_WHITE);

                sb.Append(GetIdioma(idioma, Constants.ES_PERIMETRO, Constants.EN_PERIMETRO) + 
                    (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroRectangulos).ToString(Constants.FORMAT_DECIMAL) + Constants.SPACE_WHITE);

                sb.Append(Constants.AREA + (areaCuadrados + areaCirculos + areaTriangulos + areaRectangulos).ToString(Constants.FORMAT_DECIMAL));
            }

            return sb.ToString();
        }

        public static string TraducirForma(int cantidad, string textoSingular, string textoPlural)
        {
            return cantidad == 1 ? textoSingular : textoPlural;
        }
        private static string GetHeader(int idioma, string esHeader, string enheader)
        {
            return idioma == idiomaCastellano ? esHeader : enheader;
        }
        private static string GetIdioma(int idioma, string esHeader, string enheader)
        {
            return idioma == idiomaCastellano ? esHeader : enheader;
        }
    }
}
