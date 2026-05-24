using Maple.Hook.Imp.Dobby.Static;
using Maple.Hook.WinMsg;
using Maple.ImGui.Backends.D3D11.GraphicsCore;
using Maple.ImGui.Backends.D3D11.ImGuiCore;
using Maple.ImGui.Backends.GameUI;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.ImGui.Backends.Windows.GraphicsCore;
using Maple.ImGui.Backends.Windows.ImGuiCore;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Maple.XScheduler.SetTimer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;

namespace Maple.UnityAssistant.Context
{
    public static class GameContextExtension
    {
        public static void Run<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TContextService>(
            Action<MonoGameSettings>? actionGameSettings = default,
            Action<IServiceCollection>? addServiceAction = default,
            int millisecondsTimeout = 5000)
            where TContextService : class, IGameContextService
        {

            var builder = Host.CreateApplicationBuilder();
            var services = builder.Services;
            //add logger
            services.AddLogging(p => p.AddOnlyMonoGameLogger());

            //HOOK->D3D11
            services.AddDobbyHookNativeFactory();
            services.AddD3D11FunctionsProvider();
            //true->兼容第三方已HOOK的情况
            services.AddWindowsGraphicsHookFactory(true);
            services.AddSingleton<D3D11BackendService>();
            //各种系统对接接口
            services.AddBridgeCollection();
            services.AddDefaultWin32InputBridge();
            //默认UI

            services.AddSingleton<IImGuiUIView, UIGameDataPage>();


            //MONO运行时服务
            services.AddMonoRuntimeService();
            //uitask
            services.AddWinRTSetTimerFactory();
            //HOOK->WinMsg
            services.AddWinMsgHookFactory();

            //mono内部调用服务
            services.AddMonoInternalCallService();

            //load game context service
            services.AddSingleton<TContextService>();
            services.AddSingleton<IGameContextService>(p => p.GetRequiredService<TContextService>());
            services.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<TContextService>());
            services.AddSingleton<IImGuiUnityInputBridge>(p => p.GetRequiredService<TContextService>());
            services.AddSingleton<IGameDataService>(p => p.GetRequiredService<TContextService>());
            services.AddHostedService<GameContextHostedService>();

            var settings = new MonoGameSettings();
            actionGameSettings?.Invoke(settings);
            services.AddSingleton(settings);

            addServiceAction?.Invoke(services);

            var app = builder.Build();
            Thread.Sleep(millisecondsTimeout);
            app.Run();

        }

        public static void Run_MONO<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TContextService>(
            Action<MonoGameSettings>? actionGameSettings = default,
            int millisecondsTimeout = 5000)
            where TContextService : class, IGameContextService
        { 
               Run<TContextService>(actionGameSettings, services => 
               {
                   services.AddMonoInternalCallService();
               }, millisecondsTimeout);
        }


    }


}
