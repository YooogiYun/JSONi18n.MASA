namespace JSONi18n.MASA.Shared.IServices;

public interface IJsonService
{
    bool Serialize(string json);
    bool Deserialize(string json);
    bool Parse(string json);
    string Get(string key);
    void Set(string key , string value);
    void Delete(string key);
}
