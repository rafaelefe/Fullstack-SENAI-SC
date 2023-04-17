using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class Pizza
{
    public int Id { get; set; }

    public int? IdMassa { get; set; }

    public int? IdBorda { get; set; }

    public virtual Bordum? IdBordaNavigation { get; set; }

    public virtual Massa? IdMassaNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<PizzaSabor> PizzaSabors { get; set; } = new List<PizzaSabor>();
}
