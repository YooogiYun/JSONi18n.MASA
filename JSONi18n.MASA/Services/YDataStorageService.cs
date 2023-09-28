using JSONi18n.MASA.Shared.IServices;
using JSONi18n.MASA.Shared.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace JSONi18n.MASA.Services;

// Microsoft.Extensions.ObjectPool 高级的连接池功能: 它提供了通用的对象池实现，可以方便地用于管理连接池。
public class YDataStorageService : IJsonService
{
    public YDataStorageService( )
    {

    }

    public void Delete(string key)
    {
        throw new NotImplementedException();
    }

    public bool Deserialize(string json)
    {
        throw new NotImplementedException();
    }

    public string Get(string key)
    {
        throw new NotImplementedException();
    }

    public ICollection<JsonModel> Parse(string json)
    {
        if(json == null) return null;

        ICollection<JsonModel> JsonModels = new Collection<JsonModel>();

        JsonDocument jsonDoc = JsonDocument.Parse(json);
        JsonElement root = jsonDoc.RootElement;

        if(root.ValueKind == JsonValueKind.Object)
        {
            int i = 0;
            foreach(JsonProperty property in root.EnumerateObject())
            {
                _ = JsonModels.Append(new JsonModel() { Id = i++ , KeyValue = property });
            }
        }

        return JsonModels;
    }

    public bool Serialize(string json)
    {
        throw new NotImplementedException();
    }

    public void Set(string key , string value)
    {
        throw new NotImplementedException();
    }
}