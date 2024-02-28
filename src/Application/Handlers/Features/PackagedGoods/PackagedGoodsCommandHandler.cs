using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Infrastructure.Data;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

public class PackagedGoodsCommandHandler(DataContext dataContext, IMapper mapper) :
    BaseCommandHandler(dataContext, mapper), IPackagedGoodsCommandHandler;