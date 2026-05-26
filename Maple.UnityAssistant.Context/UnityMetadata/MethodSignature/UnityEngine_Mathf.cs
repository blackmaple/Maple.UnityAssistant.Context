namespace Maple.UnityAssistant.Context.UnityMetadata.MethodSignature;

public static class UnityEngine_Mathf
{
    public const string MONO_ClosestPowerOfTwo = "UnityEngine.Mathf::ClosestPowerOfTwo";
    public const string MONO_CorrelatedColorTemperatureToRgbInjected = "UnityEngine.Mathf::CorrelatedColorTemperatureToRGB_Injected";
    public const string MONO_FloatToHalf = "UnityEngine.Mathf::FloatToHalf";
    public const string MONO_GammaToLinearSpace = "UnityEngine.Mathf::GammaToLinearSpace";
    public const string MONO_HalfToFloat = "UnityEngine.Mathf::HalfToFloat";
    public const string MONO_IsPowerOfTwo = "UnityEngine.Mathf::IsPowerOfTwo";
    public const string MONO_LinearToGammaSpace = "UnityEngine.Mathf::LinearToGammaSpace";
    public const string MONO_NextPowerOfTwo = "UnityEngine.Mathf::NextPowerOfTwo";
    public const string MONO_PerlinNoise = "UnityEngine.Mathf::PerlinNoise";

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UnityEngine_Mathf : MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        private readonly nint m_Pointer;

        public Ptr_UnityEngine_Mathf(nint ptr) { m_Pointer = ptr; }

        public nint Ptr => m_Pointer;

        public static implicit operator Ptr_UnityEngine_Mathf(nint ptr) => new Ptr_UnityEngine_Mathf(ptr);
        public static implicit operator nint(Ptr_UnityEngine_Mathf ptr) => ptr.m_Pointer;
        public static implicit operator bool(Ptr_UnityEngine_Mathf ptr) => ptr.m_Pointer != nint.Zero;

        public override string ToString() => m_Pointer.ToString("X8");
    }
    public const string IL2CPP_ClosestPowerOfTwo = "UnityEngine.Mathf::ClosestPowerOfTwo(System.Int32)";
    public const string IL2CPP_CorrelatedColorTemperatureToRGB_Injected = "UnityEngine.Mathf::CorrelatedColorTemperatureToRGB_Injected(System.Single,UnityEngine.Color&)";
    public const string IL2CPP_FloatToHalf = "UnityEngine.Mathf::FloatToHalf(System.Single)";
    public const string IL2CPP_GammaToLinearSpace = "UnityEngine.Mathf::GammaToLinearSpace(System.Single)";
    public const string IL2CPP_HalfToFloat = "UnityEngine.Mathf::HalfToFloat(System.UInt16)";
    public const string IL2CPP_IsPowerOfTwo = "UnityEngine.Mathf::IsPowerOfTwo(System.Int32)";
    public const string IL2CPP_LinearToGammaSpace = "UnityEngine.Mathf::LinearToGammaSpace(System.Single)";
    public const string IL2CPP_NextPowerOfTwo = "UnityEngine.Mathf::NextPowerOfTwo(System.Int32)";
    public const string IL2CPP_PerlinNoise = "UnityEngine.Mathf::PerlinNoise(System.Single,System.Single)";
}

