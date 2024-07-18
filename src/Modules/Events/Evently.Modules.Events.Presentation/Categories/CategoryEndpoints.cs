using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Categories;

public static class CategoryEndpoints
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        UpdateCategory.MapEndpoint(app);
        ArchiveCategory.MapEndpoint(app);
        CreateCategory.MapEndpoint(app);
        GetCategories.MapEndpoint(app);
        GetCategory.MapEndpoint(app);
    }
}
