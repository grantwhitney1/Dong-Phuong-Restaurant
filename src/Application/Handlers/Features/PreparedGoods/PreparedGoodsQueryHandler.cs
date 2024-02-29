using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

public class PreparedGoodsQueryHandler(IRepository<PreparedGood> repository, IMapper mapper) :
    QueryHandler<PreparedGood>(repository, mapper), IPreparedGoodsQueryHandler;