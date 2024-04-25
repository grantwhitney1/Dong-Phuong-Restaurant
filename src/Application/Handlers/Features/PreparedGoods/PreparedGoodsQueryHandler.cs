using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

    public class PreparedGoodsQueryHandler : QueryHandler<PreparedGood>, IPreparedGoodsQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IPreparedGoodsRepository _repository;

        public PreparedGoodsQueryHandler(IPreparedGoodsRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PreparedGoodDto>> HandleGetPreparedGoodsPagedAsync(int pageNum, int pageSize, string filter)
        {
            var preparedGoodDtos = await _repository.GetAllPreparedGoodsAsync(pageNum, pageSize, filter);
            return preparedGoodDtos;
        }
    }
