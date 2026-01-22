using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults; 

namespace MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

public record GetProductByIdQueryResult(Guid Id,
                            string Name,
                           decimal Price,
                           string Stock,
                           Guid CategoryId);

