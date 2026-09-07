using System;
using System.Collections.Generic;

namespace API_Cine.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
