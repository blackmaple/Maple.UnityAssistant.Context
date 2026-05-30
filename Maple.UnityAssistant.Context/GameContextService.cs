using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.ImGui.Backends.GameUI;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context.UnityHook;
using Maple.UnityAssistant.Context.UnityMetadata;
using Maple.UnityAssistant.Resource;
using Maple.XScheduler;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.UnityAssistant.Context
{
    public abstract partial class GameContextService<TContextMetadata>(
        ILogger logger,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler taskScheduler,
        WinMsgHookFactory winMsgHookFactory,
        MonoInternalCallService internalCallService,
        MonoGameSettings gameSettings,
        IHookFactory hookFactory,
        IXSchedulerFactory schedulerFactory) :
        IGameContextService,
        IMonoTaskScheduler<TContextMetadata>,
        IXSchedulerContext
        where TContextMetadata : class, IMonoMetadataCollector
    {
        public ILogger Logger { get; } = logger;
        public MonoGameSettings GameSettings { get; } = gameSettings;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public TaskScheduler Scheduler { get; } = taskScheduler;
        public IHookFactory HookFactory { get; } = hookFactory;
        public MonoInternalCallService InternalCallService { get; } = internalCallService;
        #region TContextMetadata

        public required TContextMetadata Context { get; set; }
        protected abstract TContextMetadata LoadContextMetadata();
        private async Task LoadContextMetadataAsync()
        {
            this.Context = await this.MonoTaskAsync((p, host) => host.LoadContextMetadata(), this).ConfigureAwait(false);
            if (this.Logger.IsEnabled(LogLevel.Information))
            {
                this.Logger.LogInformation("{MethodName}=>{ver}=>{api}", nameof(LoadContextMetadata), Context.TypeVersion, Context.ApiVersion);
            }
        }
        #endregion

        #region IXSchedulerUnmanaged
        public IXSchedulerFactory SchedulerFactory { get; } = schedulerFactory;
        public required IXSchedulerUnmanaged XScheduler { get; set; }
        protected virtual ValueTask CreateXSchedulerAsync()
        {
            using (this.Logger.Running())
            {
                this.XScheduler = this.SchedulerFactory.Create(this.GameSettings.MainWindowHandle);
                if (this.Logger.IsEnabled(LogLevel.Information))
                {
                    this.Logger.LogInformation("{MethodName}=>{MainWindowHandle}", nameof(CreateXSchedulerAsync), this.GameSettings.MainWindowHandle.ToString("X8"));
                }
            }
            return ValueTask.CompletedTask;
        }
        #endregion

        #region HookWindowMessage
        public WinMsgHookFactory WinMsgHookFactory { get; } = winMsgHookFactory;
        public required WinMsgHookItem WinMsgHookItem { get; set; }
        protected virtual ValueTask HookWindowMessageAsync()
        {
            using (this.Logger.Running())
            {
                this.WinMsgHookItem = this.WinMsgHookFactory.CreateRequiresNew(this.GameSettings.MainWindowHandle);
                this.WinMsgHookItem.AsyncCallback = AsyncCallback;
                this.WinMsgHookItem.EnabledAsyncCallback = true;
                var hookStatus = this.WinMsgHookItem.Start();
                if (this.Logger.IsEnabled(LogLevel.Information))
                {
                    this.Logger.LogInformation("{MethodName}=>{MainWindowHandle}:{msg}", nameof(HookWindowMessageAsync), this.GameSettings.MainWindowHandle.ToString("X8"), hookStatus);
                }

            }
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask AsyncCallback(WindowsMsgInfo<WinMsgHookItem> msgInfo)
        {
            return msgInfo.Msg switch
            {

                (int)EnumVirtualKeyCode.VK_F1 => F1_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F2 => F2_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F3 => F3_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F4 => F4_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F5 => F5_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F6 => F6_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F7 => F7_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F8 => F8_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F9 => F9_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F10 => F10_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F11 => F11_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F12 => F12_KeyDown(),

                (int)EnumVirtualKeyCode.VK_1 => Num1_KeyDown(),
                (int)EnumVirtualKeyCode.VK_2 => Num2_KeyDown(),
                (int)EnumVirtualKeyCode.VK_3 => Num3_KeyDown(),
                (int)EnumVirtualKeyCode.VK_4 => Num4_KeyDown(),
                (int)EnumVirtualKeyCode.VK_5 => Num5_KeyDown(),
                (int)EnumVirtualKeyCode.VK_6 => Num6_KeyDown(),
                (int)EnumVirtualKeyCode.VK_7 => Num7_KeyDown(),
                (int)EnumVirtualKeyCode.VK_8 => Num8_KeyDown(),
                (int)EnumVirtualKeyCode.VK_9 => Num9_KeyDown(),
                (int)EnumVirtualKeyCode.VK_0 => Num0_KeyDown(),

                (int)EnumVirtualKeyCode.VK_NUMPAD1 => Num1_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD2 => Num2_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD3 => Num3_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD4 => Num4_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD5 => Num5_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD6 => Num6_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD7 => Num7_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD8 => Num8_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD9 => Num9_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NUMPAD0 => Num0_KeyDown(),

                (int)EnumVirtualKeyCode.VK_UP => Up_KeyDown(),
                (int)EnumVirtualKeyCode.VK_DOWN => Down_KeyDown(),
                (int)EnumVirtualKeyCode.VK_LEFT => Left_KeyDown(),
                (int)EnumVirtualKeyCode.VK_RIGHT => Right_KeyDown(),

                (int)EnumVirtualKeyCode.VK_A => A_KeyDown(),
                (int)EnumVirtualKeyCode.VK_B => B_KeyDown(),
                (int)EnumVirtualKeyCode.VK_C => C_KeyDown(),
                (int)EnumVirtualKeyCode.VK_D => D_KeyDown(),
                (int)EnumVirtualKeyCode.VK_E => E_KeyDown(),
                (int)EnumVirtualKeyCode.VK_F => F_KeyDown(),
                (int)EnumVirtualKeyCode.VK_G => G_KeyDown(),
                (int)EnumVirtualKeyCode.VK_H => H_KeyDown(),
                (int)EnumVirtualKeyCode.VK_I => I_KeyDown(),
                (int)EnumVirtualKeyCode.VK_J => J_KeyDown(),
                (int)EnumVirtualKeyCode.VK_K => K_KeyDown(),
                (int)EnumVirtualKeyCode.VK_L => L_KeyDown(),
                (int)EnumVirtualKeyCode.VK_M => M_KeyDown(),
                (int)EnumVirtualKeyCode.VK_N => N_KeyDown(),
                (int)EnumVirtualKeyCode.VK_O => O_KeyDown(),
                (int)EnumVirtualKeyCode.VK_P => P_KeyDown(),
                (int)EnumVirtualKeyCode.VK_Q => Q_KeyDown(),
                (int)EnumVirtualKeyCode.VK_R => R_KeyDown(),
                (int)EnumVirtualKeyCode.VK_S => S_KeyDown(),
                (int)EnumVirtualKeyCode.VK_T => T_KeyDown(),
                (int)EnumVirtualKeyCode.VK_U => U_KeyDown(),
                (int)EnumVirtualKeyCode.VK_V => V_KeyDown(),
                (int)EnumVirtualKeyCode.VK_W => W_KeyDown(),
                (int)EnumVirtualKeyCode.VK_X => X_KeyDown(),
                (int)EnumVirtualKeyCode.VK_Y => Y_KeyDown(),
                (int)EnumVirtualKeyCode.VK_Z => Z_KeyDown(),
                (int)EnumVirtualKeyCode.VK_ESCAPE => Escape_KeyDown(),
                (int)EnumVirtualKeyCode.VK_TAB => Tab_KeyDown(),
                (int)EnumVirtualKeyCode.VK_CAPITAL => CapsLock_KeyDown(),
                (int)EnumVirtualKeyCode.VK_SHIFT => Shift_KeyDown(),
                (int)EnumVirtualKeyCode.VK_CONTROL => Control_KeyDown(),
                (int)EnumVirtualKeyCode.VK_MENU => Alt_KeyDown(),
                (int)EnumVirtualKeyCode.VK_SPACE => Space_KeyDown(),
                (int)EnumVirtualKeyCode.VK_RETURN => Enter_KeyDown(),
                (int)EnumVirtualKeyCode.VK_BACK => Backspace_KeyDown(),

                (int)EnumVirtualKeyCode.VK_HOME => Home_KeyDown(),
                (int)EnumVirtualKeyCode.VK_END => End_KeyDown(),
                (int)EnumVirtualKeyCode.VK_PRIOR => PageUp_KeyDown(),
                (int)EnumVirtualKeyCode.VK_NEXT => PageDown_KeyDown(),
                (int)EnumVirtualKeyCode.VK_SNAPSHOT => PrintScreen_KeyDown(),
                (int)EnumVirtualKeyCode.VK_PAUSE => Pause_KeyDown(),
                _ => ValueTask.CompletedTask

            };

        }
        protected virtual ValueTask F1_KeyDown() => ValueTask.CompletedTask;
        protected virtual ValueTask F2_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F3_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F4_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F10_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F11_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F12_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num1_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num2_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num3_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num4_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num0_KeyDown()
        {
            return ValueTask.CompletedTask;

        }


        protected virtual ValueTask Up_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Down_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Left_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Right_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask A_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask B_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask C_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask D_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask E_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask F_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask G_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask H_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask I_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask J_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask K_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask L_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask M_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask N_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask O_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask P_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Q_KeyDown() => ValueTask.CompletedTask;

        protected virtual ValueTask R_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask S_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask T_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask U_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask V_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask W_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask X_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Y_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Z_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Escape_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Tab_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask CapsLock_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Shift_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Control_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Alt_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Space_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Enter_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Backspace_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Home_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask End_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PageUp_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PageDown_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PrintScreen_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Pause_KeyDown()
        {
            return ValueTask.CompletedTask;
        }


        #endregion

        #region GameResource
        //protected List<GameCharacterResource> GameCharacterResources { get; } = [];
        //protected List<GameCurrencyResource> GameCurrencyResources { get; } = [];
        //protected List<GameInventoryResource> GameInventoryResources { get; } = [];
        //protected List<GameMonsterResource> GameMonsterResources { get; } = [];
        //protected List<GameSkillResource> GameSkillResources { get; } = [];
        //protected List<GameSwitchResource> GameSwitchResources { get; } = [];
        //protected List<IGameCommonReource> GameCommonResources { get; } = [];
        protected Dictionary<string, GameImageResource> ImageResources { get; } = [];
        protected abstract ValueTask LoadGameResourcesAsync();
        #endregion

        #region IImGuiUnityInputBridge

        protected UnityMetadataSearchService? UnityMetadataSearchService { get; set; }
        public virtual void PlatformSetImeDataFn(bool on) => this.UnityMetadataSearchService?.SetImeCompositionMode();

        public virtual bool TryGetImageInfo(string? category, string objectId, string? image, out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
        {
            Unsafe.SkipInit(out nativePtr);
            Unsafe.SkipInit(out u0);
            Unsafe.SkipInit(out v0);
            Unsafe.SkipInit(out u1);
            Unsafe.SkipInit(out v1);

            if (string.IsNullOrEmpty(image))
            {
                return false;
            }
            if (this.ImageResources.TryGetValue(image, out var imageRes) && imageRes.NativeTexturePtr != nint.Zero)
            {
                nativePtr = imageRes.NativeTexturePtr;
                u0 = imageRes.U0;
                u1 = imageRes.U1;
                v0 = imageRes.V0;
                v1 = imageRes.V1;
                return true;
            }
            return false;
            //     this.Logger.LogInformation("{category}/{objectId}=>{commonResource}", category, objectId, commonResource.ImagePointer.ToString("X8"));  
            //return unityApi.TryGetTextureInfo(commonResource.ImagePointer, out nativePtr, out u0, out v1, out u1, out v0);
        }

        public virtual bool TryDrawLauncher(out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
        {
            Unsafe.SkipInit(out nativePtr);
            Unsafe.SkipInit(out u0);
            Unsafe.SkipInit(out v0);
            Unsafe.SkipInit(out u1);
            Unsafe.SkipInit(out v1);
            if (this.ImageResources.TryGetValue(nameof(GameImageResource), out var imageRes) && imageRes.NativeTexturePtr != nint.Zero)
            {
                nativePtr = imageRes.NativeTexturePtr;
                u0 = imageRes.U0;
                u1 = imageRes.U1;
                v0 = imageRes.V0;
                v1 = imageRes.V1;
                return true;
            }
            return false;
        }



        public virtual void BlockInput(IImGuiUIView view)
        {
            var  metadataSearchService = this.UnityMetadataSearchService;
            if (metadataSearchService is not null)
            {
                var blockInput = UnityBlockInputService.Create(this.HookFactory, view, metadataSearchService);
                blockInput.BlockInput();
            }
        }

        protected virtual UnityMetadataSearchService? LoadUnityMetadataSearchService()
        {
            return UnityMetadataSearchFactory.Create(this.RuntimeContext, this.InternalCallService);
        }
        private UnityMetadataSearchService? TryLoadUnityMetadataSearchService()
        {
            using (this.Logger.Running())
            {
                try
                {
                    return LoadUnityMetadataSearchService();
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("{MethodName}=>{msg}", nameof(LoadUnityMetadataSearchService), ex.Message);
                }
            }
            return default;
        }
        private async Task TryLoadUnityMetadataSearchServiceAsync()
        {
            this.UnityMetadataSearchService = await this.MonoTaskAsync((p, host) => host.TryLoadUnityMetadataSearchService(), this).ConfigureAwait(false);
        }
        #endregion

        #region StartAsync
        public Exception? ServiceException { get; set; }

        public virtual async ValueTask StartAsync()
        {
            using (Logger.Running())
            {
                try
                {
                    await this.HookWindowMessageAsync().ConfigureAwait(false);
                    await this.CreateXSchedulerAsync().ConfigureAwait(false);

                    await this.LoadContextMetadataAsync().ConfigureAwait(false);
                    await this.TryLoadUnityMetadataSearchServiceAsync().ConfigureAwait(false);
                    await this.LoadGameResourcesAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("{MethodName}=>{ex}", nameof(StartAsync), ex);
                    this.ServiceException = ex;
                }

            }
        }
        public virtual ValueTask StopAsync()
        {
            return ValueTask.CompletedTask;
        }
        #endregion

        #region IGameWebApiControllers

        public virtual ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            if (this.ServiceException is not null)
            {
                return ValueTask.FromResult(GameException.Throw<GameSessionInfoDTO>($"Load Session Error {this.ServiceException.GetType().Name}:{this.ServiceException.Message}"));
            }
            var api = Context is not null ? Context.ApiVersion : "???";
            var data = GameSettings.GetGameSessionInfo(api);
            return ValueTask.FromResult(data);
        }

        public virtual ValueTask<GameSessionInfoDTO> LoadResourceAsync()
            => GetSessionInfoAsync();

        public virtual ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");

        public virtual ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.ThrowUIHide<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");



        public virtual ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
            => GameException.Throw<ValueTask<GameSkillDisplayDTO>>("NotImplemented");


        public virtual ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");




        public virtual ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
            => GameException.Throw<ValueTask<GameSwitchDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");

        #endregion

        #region IGameDataService
        static MonoResultDTO<T> GetErrorResult<T>(Exception ex)
        {
            return ex switch
            {
                MonoCommonException bizEx => MonoResultDTO.GetBizError<T>(bizEx),
                _ => MonoResultDTO.GetSystemError<T>(ex.Message)
            };
        }

        async Task<MonoResultDTO<GameCharacterSkillDTO>> IGameDataService.AddMonsterMemberAsync(GameSessionInfoDTO gameSessionInfo, string monsterObject)
        {
            try
            {

                var data = await this.AddMonsterMemberAsync(new GameMonsterObjectDTO() { Session = gameSessionInfo.ObjectId, MonsterObject = monsterObject }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterSkillDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameSkillDisplayDTO>> IGameDataService.AddSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo, GameSkillDisplayDTO gameSkillDisplay)
        {
            try
            {
                var data = await this.AddSkillDisplayAsync(new GameSkillObjectDTO() { Session = gameSessionInfo.ObjectId, SkillObject = gameSkillDisplay.ObjectId, SkillCategory = gameSkillDisplay.DisplayCategory }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSkillDisplayDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterEquipmentDTO>> IGameDataService.GetCharacterEquipmentAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            try
            {
                var data = await this.GetCharacterEquipmentAsync(new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterEquipmentDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterSkillDTO>> IGameDataService.GetCharacterSkillAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            try
            {
                var data = await this.GetCharacterSkillAsync(new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterSkillDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterStatusDTO>> IGameDataService.GetCharacterStatusAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            try
            {
                var data = await this.GetCharacterStatusAsync(new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterStatusDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCurrencyInfoDTO>> IGameDataService.GetCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameCurrencyId, string? category)
        {
            try
            {
                var data = await this.GetCurrencyInfoAsync(new GameCurrencyObjectDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrencyId, CurrencyCategory = category }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCurrencyInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameSessionInfoDTO>> IGameDataService.GetGameSessionInfoAsync()
        {
            try
            {
                var data = await this.GetSessionInfoAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSessionInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameInventoryInfoDTO>> IGameDataService.GetInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameInventoryId, string? category)
        {
            try
            {
                var data = await this.GetInventoryInfoAsync(new GameInventoryObjectDTO() { Session = gameSessionInfo.ObjectId, InventoryObject = gameInventoryId, InventoryCategory = category }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameInventoryInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterDisplayDTO[]>> IGameDataService.GetListCharacterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListCharacterDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameCurrencyDisplayDTO[]>> IGameDataService.GetListCurrencyDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListCurrencyDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCurrencyDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameInventoryDisplayDTO[]>> IGameDataService.GetListInventoryDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListInventoryDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameInventoryDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameMonsterDisplayDTO[]>> IGameDataService.GetListMonsterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListMonsterDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameMonsterDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameSkillDisplayDTO[]>> IGameDataService.GetListSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListSkillDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSkillDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameSwitchDisplayDTO[]>> IGameDataService.GetListSwitchDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.GetListSwitchDisplayAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSwitchDisplayDTO[]>(ex);
            }
        }

        async Task<MonoResultDTO<GameSessionInfoDTO>> IGameDataService.LoadResourceAsync(GameSessionInfoDTO gameSessionInfo)
        {
            try
            {
                var data = await this.LoadResourceAsync().ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSessionInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterEquipmentDTO>> IGameDataService.UpdateCharacterEquipmentAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, string? modifyCategory, string oldEquip, string newEquip)
        {
            try
            {
                var data = await this.UpdateCharacterEquipmentAsync(new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = modifyCategory, ModifyObject = oldEquip, NewValue = newEquip }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterEquipmentDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterSkillDTO>> IGameDataService.UpdateCharacterSkillAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, string? modifyCategory, string oldSkill, string newSkill)
        {
            try
            {
                var data = await this.UpdateCharacterSkillAsync(new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = modifyCategory, ModifyObject = oldSkill, NewValue = newSkill }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterSkillDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCharacterStatusDTO>> IGameDataService.UpdateCharacterStatusAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, GameSwitchDisplayDTO gameValueInfo)
        {
            try
            {
                var data = await this.UpdateCharacterStatusAsync(new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = gameValueInfo.DisplayCategory, ModifyObject = gameValueInfo.ObjectId, NewValue = gameValueInfo.ContentValue }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCharacterStatusDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameCurrencyInfoDTO>> IGameDataService.UpdateCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, GameCurrencyInfoDTO gameCurrency, string? category)
        {
            try
            {
                var data = await this.UpdateCurrencyInfoAsync(new GameCurrencyModifyDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrency.ObjectId, CurrencyCategory = category, NewValue = gameCurrency.DisplayValue, IntValue = int.TryParse(gameCurrency.DisplayValue, out var intValue) ? intValue : 0 }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameCurrencyInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameInventoryInfoDTO>> IGameDataService.UpdateInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string? category, GameInventoryInfoDTO gameInventory)
        {
            try
            {
                var data = await this.UpdateInventoryInfoAsync(new GameInventoryModifyDTO() { Session = gameSessionInfo.ObjectId, InventoryObject = gameInventory.ObjectId, InventoryCategory = category, NewValue = gameInventory.InventoryCount.ToString(), InventoryCount = gameInventory.InventoryCount }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameInventoryInfoDTO>(ex);
            }
        }

        async Task<MonoResultDTO<GameSwitchDisplayDTO>> IGameDataService.UpdateSwitchDisplayAsync(GameSessionInfoDTO gameSessionInfo, GameSwitchDisplayDTO gameSwitchInfo)
        {
            try
            {
                var data = await this.UpdateSwitchDisplayAsync(new GameSwitchModifyDTO() { Session = gameSessionInfo.ObjectId, SwitchObjectId = gameSwitchInfo.ObjectId, ContentValue = gameSwitchInfo.ContentValue }).ConfigureAwait(false);
                return MonoResultDTO.GetOk(data);
            }
            catch (Exception ex)
            {
                return GetErrorResult<GameSwitchDisplayDTO>(ex);
            }
        }



        #endregion
    }
}
