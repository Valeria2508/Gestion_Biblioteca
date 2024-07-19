using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Biblioteca.models;
    public class Biblioteca{
        public List<Libro> Libros { get; set; }//se crea la propiedad que dira que la lista existe

        public Biblioteca(){
            Libros = new List<Libro>();//se crea la lista
        }

        public void AgregarLibro(Libro nuevoLibro){
            Libros.Add(nuevoLibro);
            Console.WriteLine($"El libro {nuevoLibro.Titulo} ha sido agregado a la biblioteca.");
        }

        public void EliminarLibro(Libro libroAEliminar){
            Libros.Remove(libroAEliminar);
            Console.WriteLine($"El libro {libroAEliminar.Titulo} ha sido eliminado de la biblioteca.");
        }

      public void BuscarLibroPorTitulo(string titulo)
    {
        List<Libro>? librosEncontrados = Libros.FindAll(libro => libro.Titulo == titulo);
        if (librosEncontrados.Count > 0)
        {
            Console.WriteLine("Libros encontrados:");
            foreach (var libro in librosEncontrados)
            {
                Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
            }
        }
        else
        {
            Console.WriteLine("No se encontraron libros con el título ingresado");
        }
    }
    }
