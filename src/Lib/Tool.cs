using MyLib;

namespace Lib;

public static class Tool
{
    public static Person Method(string json)
        => Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
}
