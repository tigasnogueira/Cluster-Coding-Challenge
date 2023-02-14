namespace Cluster.Domain.Models;

public class Cart
{
    public int IdCart { get; set; }
    public DateTime DateCreated { get; set; }
    public string Status { get; set; }
    public MenuItem MenuItem { get; set; }
}
