namespace DongPhuong.Application.Dtos.Responses;

public class PreparedGoodResponse
{
    public ICollection<PreparedGoodQueryDto>? PreparedGoodQueryDto { get; set; } = new List<PreparedGoodQueryDto>();
}