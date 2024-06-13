
using InventoryCart.Domain.Abstractions;
using MediatR;

namespace InventoryCart.Application.Messaging
{
    public interface IQuery<TResponse>: IRequest<Result<TResponse>>
    {
    }
}
