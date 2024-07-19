using Taller_Biblioteca.models;

void Manu(){
    Console.WriteLine("#################");
    Console.WriteLine("Bienvenido a la Bibliteca");
    Console.WriteLine("1. Agregar Libro");
    Console.WriteLine("2. Eliminar Libro");
    Console.WriteLine("3. Buscar Libro");
    Console.WriteLine("4. Mostrar Libro");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elije una opcion");
    var opcion = Convert.ToInt32(Console.Read());
    Console.WriteLine("#################");

    while (true)
    {
        switch(opcion >0 && opcion < 6){
            case 1: 
            Console.WriteLine("Ingrese el nombre del libro que quieres agregar");
            var titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro que quieres agregar");
            var autor = Console.ReadLine();
            Console.WriteLine("Ingrese el ISBN del libro que quieres agregar");
            var isbn = Console.ReadLine();
            Console.WriteLine("Ingrese el genero del libro que quieres agregar");
            var genero = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del libro que quieres agregar");
            var precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el año de publicacion del libro que quieres agregar");
            var añoPublicacion = Console.Read(); 
            var libro1 = new Libro(autor,isbn,genero,precio,titulo,añoPublicacion);
            var biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(libro1);
            break;
            
        }
    }
}