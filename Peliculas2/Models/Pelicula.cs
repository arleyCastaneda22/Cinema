using System;
using System.Collections.Generic;

namespace Peliculas2.Models;

public partial class Pelicula
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Sipnosis { get; set; }

    public string? Director { get; set; }

    public string? Genero { get; set; }

    public int? Calificacion { get; set; }
}
