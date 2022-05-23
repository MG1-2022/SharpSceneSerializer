using System.ComponentModel.DataAnnotations;
using SharpSceneSerializer.DTOs.Enums;
using SharpSceneSerializer.DTOs.Interfaces;

namespace SharpSceneSerializer.DTOs.GeometryObjects;

public class BezierPatchC2 : IGeometryObject
{
    [Required]
    public ObjectType ObjectType => ObjectType.bezierPatchC2;
    [Required]
    public uint Id { get; init; }
    public string Name { get; init; }
    [Required]
    public PointRef[] controlPoints { get; init; } = new PointRef[16];
}