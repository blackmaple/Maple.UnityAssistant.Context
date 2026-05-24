using Maple.Hook.Abstractions;
using Maple.ImGui.Backends;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.RenderSpy.Graphics;
using System.Diagnostics.CodeAnalysis;

namespace Maple.UnityAssistant.Context.UnityHook
{
    public interface IUnityHookItem<T> where T : HookItem
    {

        static abstract T Create(IHookFactory hookFactory, UnityMetadataSearcher metadataSearcher);

    }
}
