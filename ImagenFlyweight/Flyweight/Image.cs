namespace ImagenFlyweight.Flyweight
{
    public class Image : IImage
    {
        public readonly string? NombreArchivo;

        public Image(string nombreArchivo)
        {
            this.NombreArchivo = nombreArchivo;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Mostrando imagen '{NombreArchivo}' en coordenadas ({x}, {y}).");
        }
    }
}
