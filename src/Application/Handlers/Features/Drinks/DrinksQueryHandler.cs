using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Domain.Dtos.Features.Drinks;

namespace DongPhuong.Application.Handlers.Features.Drinks;

    public class DrinksQueryHandler : QueryHandler<Drink>, IDrinksQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IDrinksRepository _repository;

        public DrinksQueryHandler(IDrinksRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DrinkDto>> HandleGetDrinksPagedAsync(int pageNum, int pageSize, string filter)
        {
            var drinkDtos = await _repository.GetAllDrinksAsync(pageNum, pageSize, filter);
            return drinkDtos;
        }
    }