using System.Text.Json;

namespace VulpesFormsApp.Services;

public class AttorneyDataService
{
    private readonly List<string> _firms = new();

    public AttorneyDataService(IWebHostEnvironment env)
    {
        var path = Path.Combine(env.WebRootPath, "data", "attorneys.json");
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            _firms = JsonSerializer.Deserialize<List<string>>(json) ?? new();
        }
    }

    public List<string> Search(string query)
    {
        if (string.IsNullOrWhiteSpace(query) || query.Length < 2)
            return new();

        return _firms
            .Where(f => f.Contains(query, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToList();
    }

    public List<string> GetAll() => _firms;
}