using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class Sabor
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<PizzaSabor> PizzaSabors { get; set; } = new List<PizzaSabor>();
}
