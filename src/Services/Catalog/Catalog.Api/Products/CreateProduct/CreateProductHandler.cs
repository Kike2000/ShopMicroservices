using MediatR;

namespace Catalog.Api.Products.CreateProduct
{
    //Represents the data that we need to create a new Product
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    //Represents the business logic to handle create product command
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
