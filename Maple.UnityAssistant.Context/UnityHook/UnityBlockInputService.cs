using Maple.Hook.Abstractions;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.UnityAssistant.Context.UnityHook.Hook_Input;

namespace Maple.UnityAssistant.Context.UnityHook
{
    public class UnityBlockInputService
    {

        public required GetAxisHookItem GetAxisHookItem { get; init; }
        public required GetAxisRawHookItem GetAxisRawHookItem { get; init; }
        public required GetKeyDownIntHookItem GetKeyDownIntHookItem { get; init; }
        public required GetKeyDownStringHookItem GetKeyDownStringHookItem { get; init; }
        public required GetKeyIntHookItem GetKeyIntHookItem { get; init; }
        public required GetKeyStringHookItem GetKeyStringHookItem { get; init; }
        public required GetKeyUpIntHookItem GetKeyUpIntHookItem { get; init; }
        public required GetKeyUpStringHookItem GetKeyUpStringHookItem { get; init; }
        public required GetMouseButtonDownHookItem GetMouseButtonDownHookItem { get; init; }
        public required GetMouseButtonHookItem GetMouseButtonHookItem { get; init; }
        public required GetMouseButtonUpHookItem GetMouseButtonUpHookItem { get; init; }
        public required GetMousePositionInjectedHookItem GetMousePositionInjectedHookItem { get; init; }
        public required GetMouseScrollDeltaInjectedHookItem GetMouseScrollDeltaInjectedHookItem { get; init; }

        public static UnityBlockInputService Create(IHookFactory hookFactory, UnityMetadataContext metadataContext, IImGuiUIView view, ulong code = Input.Code_Input)
        {

            var classMetadataCollection = metadataContext.GetClassMetadataCollection(code);

            var hookGetAxis = GetAxisHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetAxis.SyncCallback += (axisName, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(axisName);
            };
            AdditionalContent(hookGetAxis, view);

            var hookGetAxisRaw = GetAxisRawHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetAxisRaw.SyncCallback += (axisName, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(axisName);
            };
            AdditionalContent(hookGetAxisRaw, view);



            var hookGetKeyDownInt = GetKeyDownIntHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyDownInt.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyDownInt, view);



            var hookGetKeyDownString = GetKeyDownStringHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyDownString.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyDownString, view);


            var hookGetKeyInt = GetKeyIntHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyInt.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyInt, view);



            var hookGetKeyString = GetKeyStringHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyString.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyString, view);



            var hookGetKeyUpInt = GetKeyUpIntHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyUpInt.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyUpInt, view);



            var hookGetKeyUpString = GetKeyUpStringHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetKeyUpString.SyncCallback += static (key, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(key);
            };
            AdditionalContent(hookGetKeyUpString, view);


            var hookGetMouseButtonDown = GetMouseButtonDownHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetMouseButtonDown.SyncCallback += static (button, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(button);
            };
            AdditionalContent(hookGetMouseButtonDown, view);


            var hookGetMouseButton = GetMouseButtonHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetMouseButton.SyncCallback += static (button, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(button);
            };
            AdditionalContent(hookGetMouseButton, view);



            var hookGetMouseButtonUp = GetMouseButtonUpHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetMouseButtonUp.SyncCallback += static (button, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    return default;
                }
                return hookItem.OriginalMethod.Delegate(button);
            };
            AdditionalContent(hookGetMouseButtonUp, view);


            var hookGetMousePositionInjected = GetMousePositionInjectedHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetMousePositionInjected.SyncCallback += static (ret, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    ret.Raw = default;
                    return;
                }
                hookItem.OriginalMethod.Delegate(ret);
            };
            AdditionalContent(hookGetMousePositionInjected, view);


            var hookGetMouseScrollDeltaInjected = GetMouseScrollDeltaInjectedHookItem.Create(hookFactory, metadataContext, classMetadataCollection);
            hookGetMouseScrollDeltaInjected.SyncCallback += static (ret, hookItem) =>
            {
                if (hookItem.AdditionalContent.TryGet<IImGuiUIView>(nameof(IImGuiUIView), out var view) && view.SessionWindowVisible)
                {
                    ret.Raw = default;
                    return;
                }
                hookItem.OriginalMethod.Delegate(ret);
            };
            AdditionalContent(hookGetMouseScrollDeltaInjected, view);


            return new UnityBlockInputService()
            {
                GetAxisHookItem = hookGetAxis,
                GetAxisRawHookItem = hookGetAxisRaw,
                GetKeyDownIntHookItem = hookGetKeyDownInt,
                GetKeyDownStringHookItem = hookGetKeyDownString,
                GetKeyIntHookItem = hookGetKeyInt,
                GetKeyStringHookItem = hookGetKeyString,
                GetKeyUpIntHookItem = hookGetKeyUpInt,
                GetKeyUpStringHookItem = hookGetKeyUpString,
                GetMouseButtonDownHookItem = hookGetMouseButtonDown,
                GetMouseButtonHookItem = hookGetMouseButton,
                GetMouseButtonUpHookItem = hookGetMouseButtonUp,
                GetMousePositionInjectedHookItem = hookGetMousePositionInjected,
                GetMouseScrollDeltaInjectedHookItem = hookGetMouseScrollDeltaInjected,
            };



            static void AdditionalContent(HookItem hookItem, IImGuiUIView view) => hookItem.AdditionalContent.Set(nameof(IImGuiUIView), view);

        }

        public void BlockInput()
        {
            this.GetAxisHookItem.Enable();
            this.GetAxisRawHookItem.Enable();

            this.GetKeyDownIntHookItem.Enable();
            this.GetKeyDownStringHookItem.Enable();
            this.GetKeyIntHookItem.Enable();
            this.GetKeyStringHookItem.Enable();
            this.GetKeyUpIntHookItem.Enable();
            this.GetKeyUpStringHookItem.Enable();

            this.GetMouseButtonDownHookItem.Enable();
            this.GetMouseButtonHookItem.Enable();
            this.GetMouseButtonUpHookItem.Enable();
            this.GetMousePositionInjectedHookItem.Enable();
            this.GetMouseScrollDeltaInjectedHookItem.Enable();

        }

        public void UnBlockInput()
        {
            this.GetAxisHookItem.Disable();
            this.GetAxisRawHookItem.Disable();

            this.GetKeyDownIntHookItem.Disable();
            this.GetKeyDownStringHookItem.Disable();
            this.GetKeyIntHookItem.Disable();
            this.GetKeyStringHookItem.Disable();
            this.GetKeyUpIntHookItem.Disable();
            this.GetKeyUpStringHookItem.Disable();

            this.GetMouseButtonDownHookItem.Disable();
            this.GetMouseButtonHookItem.Disable();
            this.GetMouseButtonUpHookItem.Disable();
            this.GetMousePositionInjectedHookItem.Disable();
            this.GetMouseScrollDeltaInjectedHookItem.Disable();

        }



    }
}