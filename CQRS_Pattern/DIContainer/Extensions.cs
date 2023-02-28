using CQRS_Pattern.CQRS.Handlers.ProductHandlers;
using CQRS_Pattern.CQRS.Handlers.StudentHandlers;
using CQRS_Pattern.DAL.Context;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS_Pattern.DIContainer
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ProductContext>();
            services.AddScoped<GetProductAccountantQueryHandler>();
            services.AddScoped<GetProductWarehouseAttendantQueryHandler>();
            services.AddScoped<GetProductHRByIDQueryHandler>();
            services.AddScoped<GetProductAccountantByIDQueryHandler>();
            services.AddScoped<CreateProductCommandHandler>();
            services.AddScoped<CreateStudentCommandHandler>();
            services.AddScoped<GetAllStudentQueryHandler>();
            services.AddScoped<RemoveStudentCommandHandler>();
            services.AddScoped<GetStudentByIDQueryHandler>();
            services.AddScoped<UpdateStudentCommandHandler>();

        }
    }
}
