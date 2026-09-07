using System;
using System.Collections.Generic;

namespace API_Cine.Models;

public partial class Pelicula
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descrision { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
