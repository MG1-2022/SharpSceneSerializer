using System.Runtime.Serialization;
using System.Text.Json.Serialization;
// ReSharper disable InconsistentNaming

namespace SharpSceneSerializer.DTOs.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ObjectType
{
    [EnumMember(Value = "torus")]
    torus = 0,
    [EnumMember(Value = "bezierC0")]
    bezierC0 = 1,
    [EnumMember(Value = "bezierC2")]
    bezierC2 = 2,
    [EnumMember(Value = "interpolatedC2")]
    interpolatedC2 = 3,
}