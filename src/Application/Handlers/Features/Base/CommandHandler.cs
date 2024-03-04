using DongPhuong.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.Base;

public class CommandHandler<TEntity, TDto>(IRepository<TEntity> repository) :
    ICommandHandler<TEntity, TDto>
    where TDto : class, IDto
    where TEntity : class, IEntity
{
    public async Task<IPostResponse<TDto>> HandleAsync(IPostRequest<TDto> request)
    {
        var response = new PostResponse<TDto>();
        try
        {
            if (request.Dto is null)
            {
                response.Errors = response.Errors.Append("The request body cannot be null.");
                return response;
            }
            repository.Create(request.Dto);
        }
        catch (Exception e)
        {
            response.Errors = response.Errors.Append(e.Message);
        }
        if (response.Errors.Any())
            return response;
        await repository.SaveAsync();
        return response;
    }

    public async Task<IDeleteResponse<TDto>> HandleAsync(int id)
    {
        var response = new DeleteResponse<TDto>();
        var entity = await repository.DeleteAsync(id);
        if (entity is null)
            response.Errors = response.Errors.Append("Could not find the requested Entity.");
        await repository.SaveAsync();
        return response;
    }
}