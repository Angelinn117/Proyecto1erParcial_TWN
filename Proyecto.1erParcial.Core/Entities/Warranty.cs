namespace Proyecto._1erParcial.Core.Entities;

public class Warranty : EntityBase
{
    public int FK_idAparato { get; set; }
    public int FK_idReparacion { get; set; }
    public bool aplicacionGarantia { get; set; }
    
}