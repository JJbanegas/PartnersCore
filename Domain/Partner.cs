using Domain.Interfaces;

namespace Domain;

public class Partner : BaseModel
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}