using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services;

public class SchoolService
{
    private readonly HttpClient http;

    public SchoolService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<List<School>> GetSchools()
    {
        var schools = await http.GetFromJsonAsync<List<School>>("api/school");
        return schools ?? new List<School>();
    }
}