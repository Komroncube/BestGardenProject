namespace BestGarden.Application.Messaging;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{ }