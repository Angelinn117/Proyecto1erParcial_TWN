namespace Proyecto._1erParcial.Core.Entities;

public class Apparatus : EntityBase
{
    
    public int FK_idCliente { get; set; }
    public DateTime fechaRecepcion { get; set; }
    public string tipoAparato { get; set; }
    public string marca { get; set; }
    public string descripcionProblematica { get; set; }
    public string descripcionOpcional { get; set; }
    public string ubicacionEstante { get; set; }
    
}