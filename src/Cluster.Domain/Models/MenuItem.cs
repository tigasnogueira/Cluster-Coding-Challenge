namespace Cluster.Domain.Models;

public class MenuItem : Entity
{
    public int IdMenuItem { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Active { get; set; }
}
