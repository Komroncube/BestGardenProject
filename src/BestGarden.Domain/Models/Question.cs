namespace BestGarden.Domain.Models;
public class Question : BaseDomainEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public bool IsAnswered { get; set; }
}
