using Maple.ImGui.Backends;
using Maple.ImGui.Backends.GameUI;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;

namespace Maple.UnityAssistant.Context
{
    public interface IGameContextService :
        IGameWebApiControllers,
        IImGuiUnityInputBridge,
        IGameDataService
    {
        ValueTask StartAsync();
        ValueTask StopAsync();




    }
}
