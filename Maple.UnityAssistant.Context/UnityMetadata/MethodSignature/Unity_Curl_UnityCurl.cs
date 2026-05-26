namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class Unity_Curl_UnityCurl
{
    public const string MONO_AbortRequest = "Unity.Curl.UnityCurl::AbortRequest";
    public const string MONO_AppendHeader = "Unity.Curl.UnityCurl::AppendHeader";
    public const string MONO_CreateEasyHandle = "Unity.Curl.UnityCurl::CreateEasyHandle";
    public const string MONO_CreateMultiHandle = "Unity.Curl.UnityCurl::CreateMultiHandle";
    public const string MONO_DestroyEasyHandle = "Unity.Curl.UnityCurl::DestroyEasyHandle";
    public const string MONO_DestroyMultiHandle = "Unity.Curl.UnityCurl::DestroyMultiHandle";
    public const string MONO_FreeHeaderList = "Unity.Curl.UnityCurl::FreeHeaderList";
    public const string MONO_GetDownloadSize = "Unity.Curl.UnityCurl::GetDownloadSize";
    public const string MONO_GetMoreBody = "Unity.Curl.UnityCurl::GetMoreBody";
    public const string MONO_GetRequestErrorCode = "Unity.Curl.UnityCurl::GetRequestErrorCode";
    public const string MONO_GetRequestStatus = "Unity.Curl.UnityCurl::GetRequestStatus";
    public const string MONO_GetRequestStatusCode = "Unity.Curl.UnityCurl::GetRequestStatusCode";
    public const string MONO_GetResponseHeader = "Unity.Curl.UnityCurl::GetResponseHeader";
    public const string MONO_QueueRequest = "Unity.Curl.UnityCurl::QueueRequest";
    public const string MONO_SendMoreBody = "Unity.Curl.UnityCurl::SendMoreBody";
    public const string MONO_SetupEasyHandle = "Unity.Curl.UnityCurl::SetupEasyHandle";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_Unity_Curl_UnityCurl : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_Unity_Curl_UnityCurl(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_Unity_Curl_UnityCurl(nint ptr) => new Ptr_Unity_Curl_UnityCurl(ptr);
        public static implicit operator nint(Ptr_Unity_Curl_UnityCurl ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_Unity_Curl_UnityCurl ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
}
