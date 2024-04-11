using System;
using System.Collections.Generic;

namespace Hospital.CRUD.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Edad { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public int? NumeroHabitacion { get; set; }
}
