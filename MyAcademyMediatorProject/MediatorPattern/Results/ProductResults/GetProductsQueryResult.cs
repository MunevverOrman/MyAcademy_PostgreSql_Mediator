using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;

namespace MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

public record GetProductsQueryResult(Guid Id,
                                string Name,
                               decimal Price,
                               string Stock,
                               GetCategoriesQueryResult Category);

