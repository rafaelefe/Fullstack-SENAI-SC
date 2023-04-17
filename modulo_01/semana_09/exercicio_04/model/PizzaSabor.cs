using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class PizzaSabor
{
    public int Id { get; set; }

    public int? IdPizza { get; set; }

    public int? IdSabor { get; set; }

    public virtual Pizza? IdPizzaNavigation { get; set; }

    public virtual Sabor? IdSaborNavigation { get; set; }
}
