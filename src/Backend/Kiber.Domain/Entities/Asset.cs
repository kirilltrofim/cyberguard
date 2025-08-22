namespace Kiber.Domain.Entities;

public class Asset
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public AssetType Type { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Price { get; set; }
    public string? Rarity { get; set; }
    public string Placement { get; set; } = string.Empty;
    public bool IsAvailableInStore { get; set; }
    public double? DropProbability { get; set; }
}

public enum AssetType
{
    ProfileImage,
    ProfileFrame
}
