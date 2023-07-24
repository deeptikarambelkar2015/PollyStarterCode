using Polly.Extensions.Http;
using Polly;
using StudentAPI.Services;

namespace StudentAPI.ApiMiddleware
{
    public static class APIMiddleware
    {
        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                           .HandleTransientHttpError()
                           .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                           .WaitAndRetryAsync(2, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }
        public static void AddGradeServicesToApiContainer(this IServiceCollection services,
                                                       ConfigurationManager Configuration)
        {

            services.AddHttpClient<IGradeService, GradeService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["GradeApiConfig:BaseUrl"]);
            }).AddPolicyHandler(GetRetryPolicy()); 

        }
    }
}
