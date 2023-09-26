namespace ImagenFlyweight.Flyweight
{
    public class Image : IImage
    {
        private readonly string? _nombreArchivo;

        public Image(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Mostrando imagen '{_nombreArchivo}' en coordenadas ({x}, {y}).");
        }
    }
}
