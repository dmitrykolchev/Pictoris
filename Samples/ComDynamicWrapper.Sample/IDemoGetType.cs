namespace Tutorial;

/// <summary>
/// IUnknown based COM interface.
/// </summary>
/// <remarks>
/// Win32 C/C++ definition:
/// <code>
/// MIDL_INTERFACE("92BAA992-DB5A-4ADD-977B-B22838EE91FD")
/// IDemoGetType : public IUnknown
/// {
///     HRESULT STDMETHODCALLTYPE GetString(_Outptr_ wchar_t** str) = 0;
/// };
/// </code>
/// </remarks>
internal interface IDemoGetType
{
    /// <summary>
    /// Statically defined Interface ID.
    /// </summary>
    /// <remarks>
    /// Used instead of Type.GUID to be AOT friendly and avoid using Reflection.
    /// </remarks>
    static Guid IID_IDemoGetType = new("92BAA992-DB5A-4ADD-977B-B22838EE91FD");

    /// <summary>
    /// Get the currently stored string.
    /// </summary>
    /// <returns>Returns the stored string or <c>null</c>.</returns>
    string? GetString();
}

