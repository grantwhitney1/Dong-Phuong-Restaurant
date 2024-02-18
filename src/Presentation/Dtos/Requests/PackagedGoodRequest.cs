using DongPhuong.Application.Dtos;
using DongPhuong.Presentation.Dtos.Requests.Base;

namespace DongPhuong.Presentation.Dtos.Requests;

public class PackagedGoodRequest : BaseRequest
{
    public PackagedGoodCommandDto? PackagedGoodCommandDto { get; set; }
}