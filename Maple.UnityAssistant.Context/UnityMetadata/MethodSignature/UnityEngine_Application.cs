namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Application
{
    public const string MONO_CancelQuit = "UnityEngine.Application::CancelQuit";
    public const string MONO_CanStreamedLevelBeLoaded = "UnityEngine.Application::CanStreamedLevelBeLoaded";
    public const string MONO_GetAbsoluteUrl = "UnityEngine.Application::get_absoluteURL";
    public const string MONO_GetBackgroundLoadingPriority = "UnityEngine.Application::get_backgroundLoadingPriority";
    public const string MONO_GetBuildGuid = "UnityEngine.Application::get_buildGUID";
    public const string MONO_GetCloudProjectId = "UnityEngine.Application::get_cloudProjectId";
    public const string MONO_GetCompanyName = "UnityEngine.Application::get_companyName";
    public const string MONO_GetConsoleLogPath = "UnityEngine.Application::get_consoleLogPath";
    public const string MONO_GetDataPath = "UnityEngine.Application::get_dataPath";
    public const string MONO_GetGenuine = "UnityEngine.Application::get_genuine";
    public const string MONO_GetGenuineCheckAvailable = "UnityEngine.Application::get_genuineCheckAvailable";
    public const string MONO_GetIdentifier = "UnityEngine.Application::get_identifier";
    public const string MONO_GetInstallerName = "UnityEngine.Application::get_installerName";
    public const string MONO_GetInstallMode = "UnityEngine.Application::get_installMode";
    public const string MONO_GetInternetReachability = "UnityEngine.Application::get_internetReachability";
    public const string MONO_GetIsBatchMode = "UnityEngine.Application::get_isBatchMode";
    public const string MONO_GetIsFocused = "UnityEngine.Application::get_isFocused";
    public const string MONO_GetIsHumanControllingUs = "UnityEngine.Application::get_isHumanControllingUs";
    public const string MONO_GetIsLoadingLevel = "UnityEngine.Application::get_isLoadingLevel";
    public const string MONO_GetIsPlaying = "UnityEngine.Application::get_isPlaying";
    public const string MONO_GetIsTestRun = "UnityEngine.Application::get_isTestRun";
    public const string MONO_GetPersistentDataPath = "UnityEngine.Application::get_persistentDataPath";
    public const string MONO_GetPlatform = "UnityEngine.Application::get_platform";
    public const string MONO_GetProductName = "UnityEngine.Application::get_productName";
    public const string MONO_GetRunInBackground = "UnityEngine.Application::get_runInBackground";
    public const string MONO_GetSandboxType = "UnityEngine.Application::get_sandboxType";
    public const string MONO_GetStackTraceLogType = "UnityEngine.Application::get_stackTraceLogType";
    public const string MONO_GetStreamingAssetsPath = "UnityEngine.Application::get_streamingAssetsPath";
    public const string MONO_GetSubmitAnalytics = "UnityEngine.Application::get_submitAnalytics";
    public const string MONO_GetSystemLanguage = "UnityEngine.Application::get_systemLanguage";
    public const string MONO_GetTargetFrameRate = "UnityEngine.Application::get_targetFrameRate";
    public const string MONO_GetTemporaryCachePath = "UnityEngine.Application::get_temporaryCachePath";
    public const string MONO_GetUnityVersion = "UnityEngine.Application::get_unityVersion";
    public const string MONO_GetUnityVersionMaj = "UnityEngine.Application::get_unityVersionMaj";
    public const string MONO_GetUnityVersionMin = "UnityEngine.Application::get_unityVersionMin";
    public const string MONO_GetUnityVersionVer = "UnityEngine.Application::get_unityVersionVer";
    public const string MONO_GetVersion = "UnityEngine.Application::get_version";
    public const string MONO_GetBuildTags = "UnityEngine.Application::GetBuildTags";
    public const string MONO_GetStackTraceLogType_2 = "UnityEngine.Application::GetStackTraceLogType";
    public const string MONO_GetValueForArgv = "UnityEngine.Application::GetValueForARGV";
    public const string MONO_HasArgv = "UnityEngine.Application::HasARGV";
    public const string MONO_HasProLicense = "UnityEngine.Application::HasProLicense";
    public const string MONO_HasUserAuthorization = "UnityEngine.Application::HasUserAuthorization";
    public const string MONO_InternalExternalCall = "UnityEngine.Application::Internal_ExternalCall";
    public const string MONO_IsPlaying = "UnityEngine.Application::IsPlaying";
    public const string MONO_OpenUrl = "UnityEngine.Application::OpenURL";
    public const string MONO_Quit = "UnityEngine.Application::Quit";
    public const string MONO_RequestAdvertisingIdentifierAsync = "UnityEngine.Application::RequestAdvertisingIdentifierAsync";
    public const string MONO_RequestUserAuthorization = "UnityEngine.Application::RequestUserAuthorization";
    public const string MONO_SetBackgroundLoadingPriority = "UnityEngine.Application::set_backgroundLoadingPriority";
    public const string MONO_SetRunInBackground = "UnityEngine.Application::set_runInBackground";
    public const string MONO_SetStackTraceLogType = "UnityEngine.Application::set_stackTraceLogType";
    public const string MONO_SetTargetFrameRate = "UnityEngine.Application::set_targetFrameRate";
    public const string MONO_SetBuildTags = "UnityEngine.Application::SetBuildTags";
    public const string MONO_SetLogCallbackDefined = "UnityEngine.Application::SetLogCallbackDefined";
    public const string MONO_SetStackTraceLogType_2 = "UnityEngine.Application::SetStackTraceLogType";
    public const string MONO_Unload = "UnityEngine.Application::Unload";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Application : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Application(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Application(nint ptr) => new Ptr_UnityEngine_Application(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Application ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Application ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_CancelQuit = "UnityEngine.Application::CancelQuit()";
    public const string IL2CPP_CanStreamedLevelBeLoaded = "UnityEngine.Application::CanStreamedLevelBeLoaded(System.String)";
    public const string IL2CPP_get_absoluteURL = "UnityEngine.Application::get_absoluteURL()";
    public const string IL2CPP_get_backgroundLoadingPriority = "UnityEngine.Application::get_backgroundLoadingPriority()";
    public const string IL2CPP_get_buildGUID = "UnityEngine.Application::get_buildGUID()";
    public const string IL2CPP_get_cloudProjectId = "UnityEngine.Application::get_cloudProjectId()";
    public const string IL2CPP_get_companyName = "UnityEngine.Application::get_companyName()";
    public const string IL2CPP_get_consoleLogPath = "UnityEngine.Application::get_consoleLogPath()";
    public const string IL2CPP_get_dataPath = "UnityEngine.Application::get_dataPath()";
    public const string IL2CPP_get_genuine = "UnityEngine.Application::get_genuine()";
    public const string IL2CPP_get_genuineCheckAvailable = "UnityEngine.Application::get_genuineCheckAvailable()";
    public const string IL2CPP_get_identifier = "UnityEngine.Application::get_identifier()";
    public const string IL2CPP_get_installerName = "UnityEngine.Application::get_installerName()";
    public const string IL2CPP_get_installMode = "UnityEngine.Application::get_installMode()";
    public const string IL2CPP_get_internetReachability = "UnityEngine.Application::get_internetReachability()";
    public const string IL2CPP_get_isBatchMode = "UnityEngine.Application::get_isBatchMode()";
    public const string IL2CPP_get_isFocused = "UnityEngine.Application::get_isFocused()";
    public const string IL2CPP_get_isHumanControllingUs = "UnityEngine.Application::get_isHumanControllingUs()";
    public const string IL2CPP_get_isLoadingLevel = "UnityEngine.Application::get_isLoadingLevel()";
    public const string IL2CPP_get_isPlaying = "UnityEngine.Application::get_isPlaying()";
    public const string IL2CPP_get_isTestRun = "UnityEngine.Application::get_isTestRun()";
    public const string IL2CPP_get_persistentDataPath = "UnityEngine.Application::get_persistentDataPath()";
    public const string IL2CPP_get_platform = "UnityEngine.Application::get_platform()";
    public const string IL2CPP_get_productName = "UnityEngine.Application::get_productName()";
    public const string IL2CPP_get_runInBackground = "UnityEngine.Application::get_runInBackground()";
    public const string IL2CPP_get_sandboxType = "UnityEngine.Application::get_sandboxType()";
    public const string IL2CPP_get_stackTraceLogType = "UnityEngine.Application::get_stackTraceLogType()";
    public const string IL2CPP_get_streamingAssetsPath = "UnityEngine.Application::get_streamingAssetsPath()";
    public const string IL2CPP_get_submitAnalytics = "UnityEngine.Application::get_submitAnalytics()";
    public const string IL2CPP_get_systemLanguage = "UnityEngine.Application::get_systemLanguage()";
    public const string IL2CPP_get_targetFrameRate = "UnityEngine.Application::get_targetFrameRate()";
    public const string IL2CPP_get_temporaryCachePath = "UnityEngine.Application::get_temporaryCachePath()";
    public const string IL2CPP_get_unityVersion = "UnityEngine.Application::get_unityVersion()";
    public const string IL2CPP_get_unityVersionMaj = "UnityEngine.Application::get_unityVersionMaj()";
    public const string IL2CPP_get_unityVersionMin = "UnityEngine.Application::get_unityVersionMin()";
    public const string IL2CPP_get_unityVersionVer = "UnityEngine.Application::get_unityVersionVer()";
    public const string IL2CPP_get_version = "UnityEngine.Application::get_version()";
    public const string IL2CPP_GetBuildTags = "UnityEngine.Application::GetBuildTags()";
    public const string IL2CPP_GetStackTraceLogType = "UnityEngine.Application::GetStackTraceLogType(UnityEngine.LogType)";
    public const string IL2CPP_GetValueForARGV = "UnityEngine.Application::GetValueForARGV(System.String)";
    public const string IL2CPP_HasARGV = "UnityEngine.Application::HasARGV(System.String)";
    public const string IL2CPP_HasProLicense = "UnityEngine.Application::HasProLicense()";
    public const string IL2CPP_HasUserAuthorization = "UnityEngine.Application::HasUserAuthorization(UnityEngine.UserAuthorization)";
    public const string IL2CPP_Internal_ExternalCall = "UnityEngine.Application::Internal_ExternalCall(System.String)";
    public const string IL2CPP_IsPlaying = "UnityEngine.Application::IsPlaying(UnityEngine.Object)";
    public const string IL2CPP_OpenURL = "UnityEngine.Application::OpenURL(System.String)";
    public const string IL2CPP_Quit = "UnityEngine.Application::Quit(System.Int32)";
    public const string IL2CPP_RequestAdvertisingIdentifierAsync = "UnityEngine.Application::RequestAdvertisingIdentifierAsync(UnityEngine.Application/AdvertisingIdentifierCallback)";
    public const string IL2CPP_RequestUserAuthorization = "UnityEngine.Application::RequestUserAuthorization(UnityEngine.UserAuthorization)";
    public const string IL2CPP_set_backgroundLoadingPriority = "UnityEngine.Application::set_backgroundLoadingPriority(UnityEngine.ThreadPriority)";
    public const string IL2CPP_set_runInBackground = "UnityEngine.Application::set_runInBackground(System.Boolean)";
    public const string IL2CPP_set_stackTraceLogType = "UnityEngine.Application::set_stackTraceLogType(UnityEngine.StackTraceLogType)";
    public const string IL2CPP_set_targetFrameRate = "UnityEngine.Application::set_targetFrameRate(System.Int32)";
    public const string IL2CPP_SetBuildTags = "UnityEngine.Application::SetBuildTags(System.String[])";
    public const string IL2CPP_SetLogCallbackDefined = "UnityEngine.Application::SetLogCallbackDefined(System.Boolean)";
    public const string IL2CPP_SetStackTraceLogType = "UnityEngine.Application::SetStackTraceLogType(UnityEngine.LogType,UnityEngine.StackTraceLogType)";
    public const string IL2CPP_Unload = "UnityEngine.Application::Unload()";
}

