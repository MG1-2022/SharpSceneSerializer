using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using SharpSceneSerializer.DTOs;

namespace SharpSceneSerializer;

public static class SceneSerializer
{
    static string SerializeRegex = "(\\\"\\$type\\\":[\\s]*\\\"[^\\\"]*\\\",)";
    public static bool Serialize(Scene scene, string filePath)
    {
        string jsonString = JsonSerializer.Serialize(scene, new JsonSerializerOptions(
            new JsonSerializerOptions(JsonSerializerDefaults.General)
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                AllowTrailingCommas = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            }));
        Console.WriteLine(SerializeRegex);
        string output = Regex.Replace(jsonString, SerializeRegex, "");
        if (File.Exists(filePath))
            return false;
        File.WriteAllText(filePath, output);
        return true;
    }
}

 