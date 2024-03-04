namespace DongPhuong.Application.Responses.Features.Base;

public class Response
{
    public IEnumerable<string> Errors { get; set; } = new List<string>();
}