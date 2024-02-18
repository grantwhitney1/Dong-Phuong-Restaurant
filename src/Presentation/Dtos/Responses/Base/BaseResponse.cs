namespace DongPhuong.Presentation.Dtos.Responses.Base;

public abstract class BaseResponse
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public ICollection<string> Errors { get; set; } = new List<string>();
    public DateTime? Timestamp { get; set; }
}