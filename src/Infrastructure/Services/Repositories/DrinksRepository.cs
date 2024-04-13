using AutoMapper;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DongPhuong.Infrastructure.Services.Repositories;

    public class DrinksRepository : Repository<Drink>, IDrinksRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public DrinksRepository(DataContext dataContext, ILogger<DrinksRepository> logger, IMapper mapper)
            : base(dataContext, logger, mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<DrinkDto?> UpdateAsync(int id, DrinkDto dto)
        {
            var entity = await GetAsync(id);
            if (entity is null)
                return null;

            _mapper.Map(dto, entity);
            _dataContext.Update(entity);
            await SaveAsync();
            return dto;
        }

        public async Task<IEnumerable<DrinkDto>> GetAllDrinksAsync(int pageNum = 1, int pageSize = 10, string? filter = null)
        {
            pageNum = pageNum < 1 ? 1 : pageNum;
            pageSize = pageSize < 1 ? 1 : pageSize;

            IQueryable<Drink> query = _dataContext.Drinks;

            // Apply the filter
            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(d => d.Name.Contains(filter));
            }

            // Apply paging
            query = query.Skip((pageNum - 1) * pageSize).Take(pageSize);

            var entities = await query.ToListAsync();

            // Map to Dto
            return _mapper.Map<List<DrinkDto>>(entities);
        }
    }
