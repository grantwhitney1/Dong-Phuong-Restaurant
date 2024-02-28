using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Infrastructure.Data;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

public class PreparedGoodsCommandHandler(DataContext dataContext, IMapper mapper) :
    BaseCommandHandler(dataContext, mapper), IPreparedGoodsCommandHandler;