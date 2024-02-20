using DongPhuong.Application.Dtos.Requests.Base;

namespace DongPhuong.Application.Dtos.Requests;

public class DrinkRequest : BaseRequest
{
    public DrinkCommandDto? DrinkCommandDto { get; set; }
}    