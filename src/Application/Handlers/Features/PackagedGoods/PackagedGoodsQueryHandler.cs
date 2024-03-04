using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

public class PackagedGoodsQueryHandler(IRepository<PackagedGood> repository, IMapper mapper) :
    QueryHandler<PackagedGood>(repository, mapper), IPackagedGoodsQueryHandler;