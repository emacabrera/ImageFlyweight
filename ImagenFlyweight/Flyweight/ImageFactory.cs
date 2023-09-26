namespace ImagenFlyweight.Flyweight
{
    public class ImageFactory
    {
        private readonly Dictionary<string, IImage> _images = new();

        public IImage GetImage(string nombreArchivo)
        {
            if (!_images.ContainsKey(nombreArchivo))
            {
                Console.WriteLine($"No se encontró un valor para '{nombreArchivo}'." +
                    $" Agregando un nuevo item a la colección.");
                _images[nombreArchivo] = new Image(nombreArchivo);
            } else
            {
                Console.WriteLine($"Ya existe un objeto en la colección con la clave '{nombreArchivo}'." +
                    $" Devolviendo el valor correspondiente.");
            }

            return _images[nombreArchivo];
        }

        public void ShowFlyweights()
        {
            foreach (Image image in _images.Values)
            {
                Console.WriteLine($"{image.NombreArchivo}");
            }
        }
    }
}
