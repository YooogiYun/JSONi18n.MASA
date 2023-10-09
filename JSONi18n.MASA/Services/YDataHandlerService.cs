using JSONi18n.MASA.Shared.IServices;
using JSONi18n.MASA.Shared.Models;
using System.Buffers;
using System.Text;
using System.Text.Json;

namespace JSONi18n.MASA.Services;


/// <summary>
/// A class for parsing data and extract data.
/// </summary>
internal class YDataHandlerService : IJsonService
{
    public YDataHandlerService( ) { }

    public bool Delete(string key)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<JsonModel>> DeserializeAsync(string json , CancellationToken cancelToken)
    {
        IEnumerable<JsonModel> jsonModels = null;
        using(var jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
            var jsonStreamEnumerable = JsonSerializer.DeserializeAsyncEnumerable<JsonModel>(
                                                                                   jsonStream ,
                                                                                   cancellationToken: cancelToken);
            int i = 0;
            await foreach(var jsonItem in jsonStreamEnumerable)
            {
                jsonItem.Id = i++;
            }
        }

        return jsonModels;
    }

    public string Get(string key)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<JsonModel> Parse(string json)
    {
        if(json == null) return null;

        IEnumerable<JsonModel> JsonModels = new List<JsonModel>();

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

    public async Task<string> SerializeAsync(IEnumerable<JsonModel> json , CancellationToken cancelToken)
    {
        if(json is null)
            return string.Empty;

        var options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        using(var memoryStream = new MemoryStream())
        {
            await JsonSerializer.SerializeAsync(memoryStream , json , options , cancelToken);
            memoryStream.Seek(0 , SeekOrigin.Begin);

            var buffer = ArrayPool<byte>.Shared.Rent((int)memoryStream.Length);
            try
            {
                var result = await memoryStream.ReadAsync(buffer.AsMemory(0 , (int)memoryStream.Length) , cancelToken);
                return Encoding.UTF8.GetString(buffer , 0 , (int)memoryStream.Length);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }
    }


    public bool Set(string key , string value)
    {
        throw new NotImplementedException();
    }
}
