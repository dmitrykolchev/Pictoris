namespace Tutorial;
/// <summary>
/// IUnknown based COM interface.
/// </summary>
/// <remarks>
/// Win32 C/C++ definition:
/// <code>
/// MIDL_INTERFACE("30619FEA-E995-41EA-8C8B-9A610D32ADCB")
/// IDemoStoreType : public IUnknown
/// {
///     HRESULT STDMETHODCALLTYPE StoreString(int len, _In_z_ const wchar_t* str) = 0;
/// };
/// </code>
/// </remarks>
internal interface IDemoStoreType
{
    /// <summary>
    /// Statically defined Interface ID.
    /// </summary>
    /// <remarks>
    /// Used instead of Type.GUID to be AOT friendly and avoid using Reflection.
    /// </remarks>
    static Guid IID_IDemoStoreType = new("30619FEA-E995-41EA-8C8B-9A610D32ADCB");

    /// <summary>
    /// Store the supplied string.
    /// </summary>
    /// <param name="len">The length of the string to store.</param>
    /// <param name="str">The string to store.</param>
    void StoreString(int len, string? str);
}
