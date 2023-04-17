using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class Estado
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
