namespace Proyecto._1erParcial.Core.Entities;

public class Customer : EntityBase
{
    
    public int FK_idDireccionCliente { get; set; }
    public string nombre { get; set; }
    public string telefono { get; set; }
    
}