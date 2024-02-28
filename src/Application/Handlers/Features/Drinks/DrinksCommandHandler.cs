using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Infrastructure.Data;

namespace DongPhuong.Application.Handlers.Features.Drinks;

public class DrinksCommandHandler(DataContext dataContext, IMapper mapper) :
    BaseCommandHandler(dataContext, mapper), IDrinksCommandHandler;