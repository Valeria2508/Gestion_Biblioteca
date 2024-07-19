using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Biblioteca.models;
public class Libro : Publicacion {
    private Guid  Id { get; set;}
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public double Precio { get; set; }

    public Libro( string autor , string isbn, string genero , double precio,string titulo, int añoPublicacion  )
    {
        this.Id = Guid.NewGuid();
        this.Autor = autor;
        this.ISBN = isbn;
        this.Genero = genero;
        this.Precio = precio;
        this.Titulo = titulo;
        this.AñoPublicacion= añoPublicacion;
    }

    public void DescriptionDetallada(){
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Precio: ${Precio}");
    }

    public void DescuentoLibro(){
        double descuento = Precio * 0.10;
        double precioFinal = Precio - descuento;
        Console.WriteLine($"El precio del libro con descuento es: ${precioFinal:c}");
    }
}