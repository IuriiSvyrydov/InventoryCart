
using InventoryCart.Domain.Abstractions;
using MediatR;

namespace InventoryCart.Application.Messaging
{
    public interface IQueryHandler<TQuery,TResponse>: IRequestHandler<TQuery,Result<TResponse>>
        where TQuery: IQuery<TResponse>
    {
    }
}
