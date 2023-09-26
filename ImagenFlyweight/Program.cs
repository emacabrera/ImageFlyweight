// See https://aka.ms/new-console-template for more information

using ImagenFlyweight.Flyweight;

ImageFactory factory = new();
List<Tuple<string, int, int>> imagesToShow = new()
{
    new Tuple<string, int, int>("imagen1.jpg", 10, 20),
    new Tuple<string, int, int>("imagen2.jpg", 50, 60),
    new Tuple<string, int, int>("imagen1.jpg", 100, 120), // Imagen repetida
    new Tuple<string, int, int>("imagen3.jpg", 200, 220),
    new Tuple<string, int, int>("imagen2.jpg", 70, 80), // Imagen repetida
    new Tuple<string, int, int>("imagen2.jpg", 13, 28), // Imagen repetida
    new Tuple<string, int, int>("imagen3.jpg", 400, 560), // Imagen repetida
    new Tuple<string, int, int>("imagen4.jpg", 200, 220),
    new Tuple<string, int, int>("imagen4.jpg", 200, 220), // Imagen repetida
};

foreach (var tuple in imagesToShow)
{
    string nombreArchivo = tuple.Item1;
    int x = tuple.Item2;
    int y = tuple.Item3;

    IImage imagen = factory.GetImage(nombreArchivo); // Uso la fábrica para crear el objeto Imagen
    imagen.Display(x, y);
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Imágenes almacenadas:");
factory.ShowFlyweights();

Console.ReadKey();
