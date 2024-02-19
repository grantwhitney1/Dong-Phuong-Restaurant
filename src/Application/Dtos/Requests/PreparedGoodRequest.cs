using DongPhuong.Application.Dtos.Requests.Base;

namespace DongPhuong.Application.Dtos.Requests;

public class PreparedGoodRequest : BaseRequest
{
    public PreparedGoodCommandDto? PreparedGoodCommandDto { get; set; }
}