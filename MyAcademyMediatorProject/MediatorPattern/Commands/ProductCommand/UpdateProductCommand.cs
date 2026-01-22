using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Commands.ProductCommand;

public record UpdateProductCommand(Guid Id,
                             string Name,
                            decimal Price,
                            string Stock,
                            Guid CategoryId) : IRequest;

