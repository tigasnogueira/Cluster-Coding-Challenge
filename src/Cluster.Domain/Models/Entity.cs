using System.ComponentModel.DataAnnotations;

namespace Cluster.Domain.Models;

public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id { get; set; }

    public DateTime DateCreated { get; set; }
}
