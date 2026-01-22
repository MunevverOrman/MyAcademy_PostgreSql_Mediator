using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Commands.ProductCommand;

public record RemoveProductCommand(Guid Id): IRequest;
