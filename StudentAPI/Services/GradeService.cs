
using System.Net.Http.Json;

namespace StudentAPI.Services
{
    public class GradeService : IGradeService
    {
        private readonly HttpClient _httpClient;
        
        public GradeService()
        {
            
        }

        public async Task<int> GetStudentGrade(int id)
        {
            return 1;
            //string url = _httpClient.BaseAddress.ToString()+ Convert.ToString(id);
            //return await _httpClient.GetFromJsonAsync<int>(url);
        }
    }
}
