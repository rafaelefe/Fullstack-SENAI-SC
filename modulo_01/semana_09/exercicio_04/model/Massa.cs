using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class Massa
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
}
