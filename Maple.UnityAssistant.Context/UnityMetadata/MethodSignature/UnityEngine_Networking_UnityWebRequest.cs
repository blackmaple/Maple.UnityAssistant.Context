namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Networking_UnityWebRequest
{
    public const string MONO_Abort = "UnityEngine.Networking.UnityWebRequest::Abort";
    public const string MONO_BeginWebRequest = "UnityEngine.Networking.UnityWebRequest::BeginWebRequest";
    public const string MONO_ClearCookieCache = "UnityEngine.Networking.UnityWebRequest::ClearCookieCache";
    public const string MONO_Create = "UnityEngine.Networking.UnityWebRequest::Create";
    public const string MONO_GetDownloadedBytes = "UnityEngine.Networking.UnityWebRequest::get_downloadedBytes";
    public const string MONO_GetIsModifiable = "UnityEngine.Networking.UnityWebRequest::get_isModifiable";
    public const string MONO_GetResponseCode = "UnityEngine.Networking.UnityWebRequest::get_responseCode";
    public const string MONO_GetResult = "UnityEngine.Networking.UnityWebRequest::get_result";
    public const string MONO_GetUploadedBytes = "UnityEngine.Networking.UnityWebRequest::get_uploadedBytes";
    public const string MONO_GetUse100Continue = "UnityEngine.Networking.UnityWebRequest::get_use100Continue";
    public const string MONO_GetChunked = "UnityEngine.Networking.UnityWebRequest::GetChunked";
    public const string MONO_GetCustomMethod = "UnityEngine.Networking.UnityWebRequest::GetCustomMethod";
    public const string MONO_GetDownloadProgress = "UnityEngine.Networking.UnityWebRequest::GetDownloadProgress";
    public const string MONO_GetError = "UnityEngine.Networking.UnityWebRequest::GetError";
    public const string MONO_GetHttpstatusString = "UnityEngine.Networking.UnityWebRequest::GetHTTPStatusString";
    public const string MONO_GetMethod = "UnityEngine.Networking.UnityWebRequest::GetMethod";
    public const string MONO_GetRedirectLimit = "UnityEngine.Networking.UnityWebRequest::GetRedirectLimit";
    public const string MONO_GetRequestHeader = "UnityEngine.Networking.UnityWebRequest::GetRequestHeader";
    public const string MONO_GetResponseHeader = "UnityEngine.Networking.UnityWebRequest::GetResponseHeader";
    public const string MONO_GetResponseHeaderKeys = "UnityEngine.Networking.UnityWebRequest::GetResponseHeaderKeys";
    public const string MONO_GetSuppressErrorsToConsole = "UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole";
    public const string MONO_GetTimeoutMsec = "UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec";
    public const string MONO_GetUploadProgress = "UnityEngine.Networking.UnityWebRequest::GetUploadProgress";
    public const string MONO_GetUrl = "UnityEngine.Networking.UnityWebRequest::GetUrl";
    public const string MONO_GetWebErrorString = "UnityEngine.Networking.UnityWebRequest::GetWebErrorString";
    public const string MONO_InternalSetRequestHeader = "UnityEngine.Networking.UnityWebRequest::InternalSetRequestHeader";
    public const string MONO_IsExecuting = "UnityEngine.Networking.UnityWebRequest::IsExecuting";
    public const string MONO_Release = "UnityEngine.Networking.UnityWebRequest::Release";
    public const string MONO_SetUse100Continue = "UnityEngine.Networking.UnityWebRequest::set_use100Continue";
    public const string MONO_SetCertificateHandler = "UnityEngine.Networking.UnityWebRequest::SetCertificateHandler";
    public const string MONO_SetChunked = "UnityEngine.Networking.UnityWebRequest::SetChunked";
    public const string MONO_SetCustomMethod = "UnityEngine.Networking.UnityWebRequest::SetCustomMethod";
    public const string MONO_SetDownloadHandler = "UnityEngine.Networking.UnityWebRequest::SetDownloadHandler";
    public const string MONO_SetMethod = "UnityEngine.Networking.UnityWebRequest::SetMethod";
    public const string MONO_SetRedirectLimitFromScripting = "UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting";
    public const string MONO_SetSuppressErrorsToConsole = "UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole";
    public const string MONO_SetTimeoutMsec = "UnityEngine.Networking.UnityWebRequest::SetTimeoutMsec";
    public const string MONO_SetUploadHandler = "UnityEngine.Networking.UnityWebRequest::SetUploadHandler";
    public const string MONO_SetUrl = "UnityEngine.Networking.UnityWebRequest::SetUrl";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Networking_UnityWebRequest : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Networking_UnityWebRequest(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Networking_UnityWebRequest(nint ptr) => new Ptr_UnityEngine_Networking_UnityWebRequest(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Networking_UnityWebRequest ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Networking_UnityWebRequest ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_Abort = "UnityEngine.Networking.UnityWebRequest::Abort()";
    public const string IL2CPP_BeginWebRequest = "UnityEngine.Networking.UnityWebRequest::BeginWebRequest()";
    public const string IL2CPP_ClearCookieCache = "UnityEngine.Networking.UnityWebRequest::ClearCookieCache(System.String,System.String)";
    public const string IL2CPP_Create = "UnityEngine.Networking.UnityWebRequest::Create()";
    public const string IL2CPP_get_downloadedBytes = "UnityEngine.Networking.UnityWebRequest::get_downloadedBytes()";
    public const string IL2CPP_get_isModifiable = "UnityEngine.Networking.UnityWebRequest::get_isModifiable()";
    public const string IL2CPP_get_responseCode = "UnityEngine.Networking.UnityWebRequest::get_responseCode()";
    public const string IL2CPP_get_result = "UnityEngine.Networking.UnityWebRequest::get_result()";
    public const string IL2CPP_get_uploadedBytes = "UnityEngine.Networking.UnityWebRequest::get_uploadedBytes()";
    public const string IL2CPP_get_use100Continue = "UnityEngine.Networking.UnityWebRequest::get_use100Continue()";
    public const string IL2CPP_GetChunked = "UnityEngine.Networking.UnityWebRequest::GetChunked()";
    public const string IL2CPP_GetCustomMethod = "UnityEngine.Networking.UnityWebRequest::GetCustomMethod()";
    public const string IL2CPP_GetDownloadProgress = "UnityEngine.Networking.UnityWebRequest::GetDownloadProgress()";
    public const string IL2CPP_GetError = "UnityEngine.Networking.UnityWebRequest::GetError()";
    public const string IL2CPP_GetHTTPStatusString = "UnityEngine.Networking.UnityWebRequest::GetHTTPStatusString(System.Int64)";
    public const string IL2CPP_GetMethod = "UnityEngine.Networking.UnityWebRequest::GetMethod()";
    public const string IL2CPP_GetRedirectLimit = "UnityEngine.Networking.UnityWebRequest::GetRedirectLimit()";
    public const string IL2CPP_GetRequestHeader = "UnityEngine.Networking.UnityWebRequest::GetRequestHeader(System.String)";
    public const string IL2CPP_GetResponseHeader = "UnityEngine.Networking.UnityWebRequest::GetResponseHeader(System.String)";
    public const string IL2CPP_GetResponseHeaderKeys = "UnityEngine.Networking.UnityWebRequest::GetResponseHeaderKeys()";
    public const string IL2CPP_GetSuppressErrorsToConsole = "UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole()";
    public const string IL2CPP_GetTimeoutMsec = "UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec()";
    public const string IL2CPP_GetUploadProgress = "UnityEngine.Networking.UnityWebRequest::GetUploadProgress()";
    public const string IL2CPP_GetUrl = "UnityEngine.Networking.UnityWebRequest::GetUrl()";
    public const string IL2CPP_GetWebErrorString = "UnityEngine.Networking.UnityWebRequest::GetWebErrorString(UnityEngine.Networking.UnityWebRequest/UnityWebRequestError)";
    public const string IL2CPP_InternalSetRequestHeader = "UnityEngine.Networking.UnityWebRequest::InternalSetRequestHeader(System.String,System.String)";
    public const string IL2CPP_IsExecuting = "UnityEngine.Networking.UnityWebRequest::IsExecuting()";
    public const string IL2CPP_Release = "UnityEngine.Networking.UnityWebRequest::Release()";
    public const string IL2CPP_set_use100Continue = "UnityEngine.Networking.UnityWebRequest::set_use100Continue(System.Boolean)";
    public const string IL2CPP_SetCertificateHandler = "UnityEngine.Networking.UnityWebRequest::SetCertificateHandler(UnityEngine.Networking.CertificateHandler)";
    public const string IL2CPP_SetChunked = "UnityEngine.Networking.UnityWebRequest::SetChunked(System.Boolean)";
    public const string IL2CPP_SetCustomMethod = "UnityEngine.Networking.UnityWebRequest::SetCustomMethod(System.String)";
    public const string IL2CPP_SetDownloadHandler = "UnityEngine.Networking.UnityWebRequest::SetDownloadHandler(UnityEngine.Networking.DownloadHandler)";
    public const string IL2CPP_SetMethod = "UnityEngine.Networking.UnityWebRequest::SetMethod(UnityEngine.Networking.UnityWebRequest/UnityWebRequestMethod)";
    public const string IL2CPP_SetRedirectLimitFromScripting = "UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting(System.Int32)";
    public const string IL2CPP_SetSuppressErrorsToConsole = "UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole(System.Boolean)";
    public const string IL2CPP_SetTimeoutMsec = "UnityEngine.Networking.UnityWebRequest::SetTimeoutMsec(System.Int32)";
    public const string IL2CPP_SetUploadHandler = "UnityEngine.Networking.UnityWebRequest::SetUploadHandler(UnityEngine.Networking.UploadHandler)";
    public const string IL2CPP_SetUrl = "UnityEngine.Networking.UnityWebRequest::SetUrl(System.String)";
}

