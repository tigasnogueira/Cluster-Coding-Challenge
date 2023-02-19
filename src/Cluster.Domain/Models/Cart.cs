namespace Cluster.Domain.Models;

public class Cart : Entity
{
    public int IdCart { get; set; }
    public string Status { get; set; }
    public MenuItem MenuItem { get; set; }
}
