using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Commands.ProductCommand;

public record CreateProductCommand(string Name,
                                   decimal Price,
                                   string Stock, 
                                   Guid CategoryId) : IRequest;

