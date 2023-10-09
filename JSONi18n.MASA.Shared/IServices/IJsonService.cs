using JSONi18n.MASA.Shared.Models;

namespace JSONi18n.MASA.Shared.IServices;

public interface IJsonService
{
    Task<string> SerializeAsync(IEnumerable<JsonModel> json , CancellationToken cancelToken);
    Task<IEnumerable<JsonModel>> DeserializeAsync(string json , CancellationToken cancelToken);
    IEnumerable<JsonModel> Parse(string json);
    string Get(string key);
    bool Set(string key , string value);
    bool Delete(string key);
}
