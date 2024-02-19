using DongPhuong.Application.Dtos.Requests.Base;

namespace DongPhuong.Application.Dtos.Requests;

public class PackagedGoodRequest : BaseRequest
{
    public PackagedGoodCommandDto? PackagedGoodCommandDto { get; set; }
}