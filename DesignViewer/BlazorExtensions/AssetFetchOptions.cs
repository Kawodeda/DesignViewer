
public enum AssetType
{
    Image,
    Mockup
}

public class AssetFetchOptions
{
    public AssetFetchOptions(AssetType assetType) 
    {
        AssetType= assetType;
    }

    public AssetType AssetType { get; }
}