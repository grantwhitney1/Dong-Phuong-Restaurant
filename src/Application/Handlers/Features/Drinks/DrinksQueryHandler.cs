using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.Drinks;

public class DrinksQueryHandler(IRepository<Drink> repository, IMapper mapper) :
    QueryHandler<Drink>(repository, mapper), IDrinksQueryHandler;