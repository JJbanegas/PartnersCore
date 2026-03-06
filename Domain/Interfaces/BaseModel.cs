namespace Domain.Interfaces;

public abstract class BaseModel
{
    public int Id { get; set; }
    public Guid Uuid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}