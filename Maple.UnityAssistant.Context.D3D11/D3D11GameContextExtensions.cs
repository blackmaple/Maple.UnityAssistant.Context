using Maple.ImGui.Backends.D3D11.GraphicsCore;
using Maple.ImGui.Backends.D3D11.ImGuiCore;
using Maple.ImGui.Backends.Windows.ImGuiCore;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Maple.UnityAssistant.Context.D3D11
{
    public static class D3D11GameContextExtensions
    {
        public static void Run<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TContextService>(
            Action<MonoGameSettings>? actionGameSettings = default,
            Action<IServiceCollection>? addServiceAction = default,
            int millisecondsTimeout = 5000)
            where TContextService : class, IGameContextService
        {

            GameContextExtensions.Run<TContextService>(actionGameSettings, (services) => 
            {
                services.AddD3D11FunctionsProvider();
                services.AddSingleton<Win32ImGuiBackendService, D3D11BackendService>();
                addServiceAction?.Invoke(services);
            }, millisecondsTimeout);
        }
    }
}
