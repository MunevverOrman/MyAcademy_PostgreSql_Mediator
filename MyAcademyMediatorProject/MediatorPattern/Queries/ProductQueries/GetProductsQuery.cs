using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

namespace MyAcademyMediatorProject.MediatorPattern.Queries.ProductQueries
{
    public class GetProductsQuery:IRequest<List<GetProductsQueryResult>>
    {
    }
}
