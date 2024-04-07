using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

    public class PackagedGoodsQueryHandler : QueryHandler<PackagedGood>, IPackagedGoodsQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IPackagedGoodsRepository _repository;

        public PackagedGoodsQueryHandler(IPackagedGoodsRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PackagedGoodDto>> HandleGetPackagedGoodsPagedAsync(int pageNum, int pageSize, string filter)
        {
            var packagedGoodDtos = await _repository.GetAllPackagedGoodsAsync(pageNum, pageSize, filter);
            return packagedGoodDtos;
        }
    }
