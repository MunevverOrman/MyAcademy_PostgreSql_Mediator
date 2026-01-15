using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;
using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries
{
    public class GetCategoriesQuery: IRequest<List<GetCategoriesQueryResult>>
    {
    }
}
