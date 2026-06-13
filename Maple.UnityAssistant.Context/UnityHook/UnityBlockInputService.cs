using Maple.Hook.Abstractions;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.UnityAssistant.Context.UnityHook.Hook_Input;
using Maple.UnityAssistant.Context.UnityMetadata;
using Microsoft.Extensions.Logging;

namespace Maple.UnityAssistant.Context.UnityHook
{
    public class UnityBlockInputService
    {

        //public GetAxisHookItem? GetAxisHookItem { get; init; }
        //public GetAxisRawHookItem? GetAxisRawHookItem { get; init; }
        //public GetKeyDownIntHookItem? GetKeyDownIntHookItem { get; init; }
        //public GetKeyDownStringHookItem? GetKeyDownStringHookItem { get; init; }
        //public GetKeyIntHookItem? GetKeyIntHookItem { get; init; }
        //public GetKeyStringHookItem? GetKeyStringHookItem { get; init; }
        //public GetKeyUpIntHookItem? GetKeyUpIntHookItem { get; init; }
        //public GetKeyUpStringHookItem? GetKeyUpStringHookItem { get; init; }
        //public GetMouseButtonDownHookItem? GetMouseButtonDownHookItem { get; init; }
        //public GetMouseButtonHookItem? GetMouseButtonHookItem { get; init; }
        //public GetMouseButtonUpHookItem? GetMouseButtonUpHookItem { get; init; }
        //public GetMousePositionInjectedHookItem? GetMousePositionInjectedHookItem { get; init; }
        //public GetMouseScrollDeltaInjectedHookItem? GetMouseScrollDeltaInjectedHookItem { get; init; }
        public required HookItem[] HookItems { get; init; }
        public static UnityBlockInputService Create(IHookFactory hookFactory, IImGuiUIView view, UnityMetadataSearchService metadataSearcher)
        {


            HookItem[] hookItems = [.. CreateHookItems(hookFactory, view, metadataSearcher)];

            var logger = metadataSearcher.Logger;
            if (logger.IsEnabled(LogLevel.Information))
            {
                foreach (var hookItem in hookItems)
                {
                    logger.LogInformation("HookItem created: {MethodName}", hookItem.GetType().Name);
                }
            }

            return new UnityBlockInputService()
            {
                HookItems = hookItems
                //GetAxisHookItem = hookGetAxis,
                //GetAxisRawHookItem = hookGetAxisRaw,
                //GetKeyDownIntHookItem = hookGetKeyDownInt,
                //GetKeyDownStringHookItem = hookGetKeyDownString,
                //GetKeyIntHookItem = hookGetKeyInt,
                //GetKeyStringHookItem = hookGetKeyString,
                //GetKeyUpIntHookItem = hookGetKeyUpInt,
                //GetKeyUpStringHookItem = hookGetKeyUpString,
                //GetMouseButtonDownHookItem = hookGetMouseButtonDown,
                //GetMouseButtonHookItem = hookGetMouseButton,
                //GetMouseButtonUpHookItem = hookGetMouseButtonUp,
                //GetMousePositionInjectedHookItem = hookGetMousePositionInjected,
                //GetMouseScrollDeltaInjectedHookItem = hookGetMouseScrollDeltaInjected,
            };




        }
        static HookItem AdditionalContent(HookItem hookItem, IImGuiUIView view)
        {
            hookItem.AdditionalContent.Set(nameof(IImGuiUIView), view);
            return hookItem;

        }
        static IEnumerable<HookItem> CreateHookItems(IHookFactory hookFactory, IImGuiUIView view, UnityMetadataSearchService metadataSearcher)
        {
            var hookGetAxis = GetAxisHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetAxis is not null)
            {
                hookGetAxis.SyncCallback += (axisName, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(axisName);
                };
                yield return AdditionalContent(hookGetAxis, view);

            }


            var hookGetAxisRaw = GetAxisRawHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetAxisRaw is not null)
            {
                hookGetAxisRaw.SyncCallback += (axisName, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(axisName);
                };
                yield return AdditionalContent(hookGetAxisRaw, view);
            }




            var hookGetKeyDownInt = GetKeyDownIntHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyDownInt is not null)
            {
                hookGetKeyDownInt.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyDownInt, view);
            }




            var hookGetKeyDownString = GetKeyDownStringHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyDownString is not null)
            {
                hookGetKeyDownString.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyDownString, view);
            }



            var hookGetKeyInt = GetKeyIntHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyInt is not null)
            {
                hookGetKeyInt.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyInt, view);
            }




            var hookGetKeyString = GetKeyStringHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyString is not null)
            {
                hookGetKeyString.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyString, view);
            }




            var hookGetKeyUpInt = GetKeyUpIntHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyUpInt is not null)
            {
                hookGetKeyUpInt.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyUpInt, view);
            }




            var hookGetKeyUpString = GetKeyUpStringHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetKeyUpString is not null)
            {
                hookGetKeyUpString.SyncCallback += static (key, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(key);
                };
                yield return AdditionalContent(hookGetKeyUpString, view);
            }



            var hookGetMouseButtonDown = GetMouseButtonDownHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetMouseButtonDown is not null)
            {
                hookGetMouseButtonDown.SyncCallback += static (button, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(button);
                };
                yield return AdditionalContent(hookGetMouseButtonDown, view);
            }



            var hookGetMouseButton = GetMouseButtonHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetMouseButton is not null)
            {
                hookGetMouseButton.SyncCallback += static (button, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(button);
                };
                yield return AdditionalContent(hookGetMouseButton, view);

            }



            var hookGetMouseButtonUp = GetMouseButtonUpHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetMouseButtonUp is not null)
            {
                hookGetMouseButtonUp.SyncCallback += static (button, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        return default;
                    }
                    return hookItem.OriginalMethod.Delegate(button);
                };
                yield return AdditionalContent(hookGetMouseButtonUp, view);
            }



            var hookGetMousePositionInjected = GetMousePositionInjectedHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetMousePositionInjected is not null)
            {
                hookGetMousePositionInjected.SyncCallback += static (ret, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        ret.Raw = default;
                        return;
                    }
                    hookItem.OriginalMethod.Delegate(ret);
                };
                yield return AdditionalContent(hookGetMousePositionInjected, view);
            }



            var hookGetMouseScrollDeltaInjected = GetMouseScrollDeltaInjectedHookItem.Create(hookFactory, metadataSearcher);
            if (hookGetMouseScrollDeltaInjected is not null)
            {
                hookGetMouseScrollDeltaInjected.SyncCallback += static (ret, hookItem) =>
                {
                    if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                    {
                        ret.Raw = default;
                        return;
                    }
                    hookItem.OriginalMethod.Delegate(ret);
                };
                yield return AdditionalContent(hookGetMouseScrollDeltaInjected, view);

            }
        }

        public void BlockInput()
        {
            //this.GetAxisHookItem.Enable();
            //this.GetAxisRawHookItem.Enable();

            //this.GetKeyDownIntHookItem.Enable();
            //this.GetKeyDownStringHookItem.Enable();
            //this.GetKeyIntHookItem.Enable();
            //this.GetKeyStringHookItem.Enable();
            //this.GetKeyUpIntHookItem.Enable();
            //this.GetKeyUpStringHookItem.Enable();

            //this.GetMouseButtonDownHookItem.Enable();
            //this.GetMouseButtonHookItem.Enable();
            //this.GetMouseButtonUpHookItem.Enable();
            //this.GetMousePositionInjectedHookItem.Enable();
            //this.GetMouseScrollDeltaInjectedHookItem.Enable();

            foreach (var item in this.HookItems)
            {
                item.Enable();
            }

        }

        public void UnBlockInput()
        {
            //this.GetAxisHookItem.Disable();
            //this.GetAxisRawHookItem.Disable();

            //this.GetKeyDownIntHookItem.Disable();
            //this.GetKeyDownStringHookItem.Disable();
            //this.GetKeyIntHookItem.Disable();
            //this.GetKeyStringHookItem.Disable();
            //this.GetKeyUpIntHookItem.Disable();
            //this.GetKeyUpStringHookItem.Disable();

            //this.GetMouseButtonDownHookItem.Disable();
            //this.GetMouseButtonHookItem.Disable();
            //this.GetMouseButtonUpHookItem.Disable();
            //this.GetMousePositionInjectedHookItem.Disable();
            //this.GetMouseScrollDeltaInjectedHookItem.Disable();
            foreach (var item in this.HookItems)
            {
                item.Disable();
            }
        }



    }
}