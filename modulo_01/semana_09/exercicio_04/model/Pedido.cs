using System;
using System.Collections.Generic;

namespace Pizzaria.model;

public partial class Pedido
{
    public int Id { get; set; }

    public int? IdPizza { get; set; }

    public int? IdEstado { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual Pizza? IdPizzaNavigation { get; set; }
}
