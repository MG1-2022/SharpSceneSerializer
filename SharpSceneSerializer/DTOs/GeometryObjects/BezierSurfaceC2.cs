using System.ComponentModel.DataAnnotations;
using SharpSceneSerializer.DTOs.Enums;
using SharpSceneSerializer.DTOs.Interfaces;

namespace SharpSceneSerializer.DTOs.GeometryObjects;

public class BezierSurfaceC2 : IGeometryObject
{
    [Required]
    public ObjectType ObjectType => ObjectType.bezierSurfaceC2;
    [Required]
    public uint Id { get; init; }
    public string Name { get; init; }
    [Required]
    public BezierPatchC2[] Patches { get; init; }
}