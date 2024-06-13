
using InventoryCart.Domain.Abstractions;
using MediatR;

namespace InventoryCart.Application.Messaging
{
    public interface ICommand: IRequest<Result>, IBaseCommand
    {
    }
    public interface ICommand<TResponse>: IRequest<Result<TResponse>>, IBaseCommand
    {

    }
    public interface IBaseCommand
    {

    }
}
