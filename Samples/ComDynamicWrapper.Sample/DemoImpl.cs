namespace Tutorial;
/// <summary>
/// Managed implementation
/// </summary>
internal class DemoImpl : IDemoGetType, IDemoStoreType
{
    private string? _string;
    public string? GetString() => _string;
    public void StoreString(int _, string? str) => _string = str;
}