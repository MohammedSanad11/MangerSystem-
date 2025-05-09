using Azure;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace UserManegmenySystem.API
{
    public class AddSwaggerDefaultResponseFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var errorResponse = new OpenApiResponse
            {
                Description = "Error response",
                Content = {
                ["application/json"] = new OpenApiMediaType
                {
                    Schema = context.SchemaGenerator.GenerateSchema(typeof(CoustomEroer<Response>), context.SchemaRepository)
                }
            }
            };

            operation.Responses.TryAdd("400", errorResponse);
            operation.Responses.TryAdd("500", errorResponse);
        }
    }
}
