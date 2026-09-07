using System;
using System.Collections.Generic;

namespace API_Cine.Models;

public partial class Registro
{
    public int Id { get; set; }

    public int? IdUsuaario { get; set; }

    public int? IdPelicula { get; set; }

    public virtual Pelicula? IdPeliculaNavigation { get; set; }

    public virtual Usuario? IdUsuaarioNavigation { get; set; }
}
