using StudentAPI.Services;

namespace StudentAPI.ApiMiddleware
{
    public static class APIMiddleware
    {
        public static void AddGradeServicesToApiContainer(this IServiceCollection services,
                                                       ConfigurationManager Configuration)
        {

            services.AddHttpClient<IGradeService, GradeService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["GradeApiConfig:BaseUrl"]);
            });

        }
    }
}
