using Maple.ImGui.Backends.Windows.ImGuiCore;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Maple.UnityAssistant.Context
{
    public class GameContextHostedService(ILogger<GameContextHostedService> logger, IServiceProvider serviceProvider) : IHostedService
    {
        IServiceProvider ServiceProvider { get; } = serviceProvider;
        ILogger Logger { get; } = logger;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (this.Logger.Running())
            {
                await LoadMonoRuntimeAsync(cancellationToken).ConfigureAwait(false);
                await LoadGameContextServiceAsync(cancellationToken).ConfigureAwait(false);
                await LoadWin32ImGuiBackendServiceAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private Task LoadMonoRuntimeAsync(CancellationToken _)
        {
            using (this.Logger.Running())
            {
                try
                {
                    var runtimeFactory = ServiceProvider.GetRequiredService<MonoRuntimeFactory>();
                    var init = runtimeFactory.CreateMonoRuntime(out var runtimeType);
                    if (this.Logger.IsEnabled(LogLevel.Information))
                    {
                        this.Logger.LogInformation("{methodName}=>{init}:{runtimeType}", nameof(LoadMonoRuntimeAsync), init, runtimeType);
                    }
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("{methodName}=>{ex}", nameof(LoadMonoRuntimeAsync), ex);
                }
            }
            return Task.CompletedTask;
        }
        private async Task LoadGameContextServiceAsync(CancellationToken _)
        {
            using (this.Logger.Running())
            {
                try
                {
                    var gameContextService = ServiceProvider.GetRequiredService<IGameContextService>();
                    await gameContextService.StartAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("{methodName}=>{ex}", nameof(LoadGameContextServiceAsync), ex);
                }
            }


        }
        private async Task LoadWin32ImGuiBackendServiceAsync(CancellationToken cancellationToken)
        {
            using (this.Logger.Running())
            {
                try
                {
                    var backendService = ServiceProvider.GetRequiredService<Win32ImGuiBackendService>();
                    await backendService.StartAsync(cancellationToken).ConfigureAwait(false);
                    if (this.Logger.IsEnabled(LogLevel.Information))
                    {
                        this.Logger.LogInformation("{methodName}=>{fullName}", nameof(LoadWin32ImGuiBackendServiceAsync), backendService.GetType().FullName);
                    }
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("{methodName}=>{ex}", nameof(LoadWin32ImGuiBackendServiceAsync), ex);
                }

            }

        }

    }


}
