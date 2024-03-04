namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IResponse
{
    public IEnumerable<string> Errors { get; set; }
}