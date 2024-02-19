namespace DongPhuong.Application.Dtos.Requests.Base;

public class QueryParameters
{
    public int Page { get; set; }
    public int Limit { get; set; }
    public ICollection<Criterion> Criteria { get; set; } = new List<Criterion>();
}