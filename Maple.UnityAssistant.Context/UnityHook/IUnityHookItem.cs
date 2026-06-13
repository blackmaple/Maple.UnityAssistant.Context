using Maple.Hook.Abstractions;
using Maple.UnityAssistant.Context.UnityMetadata;

namespace Maple.UnityAssistant.Context.UnityHook
{
    public interface IUnityHookItem<T> where T :    HookItem 
    {

        static abstract T? Create(IHookFactory hookFactory, UnityMetadataSearchService metadataSearcher);
           

    }
}
