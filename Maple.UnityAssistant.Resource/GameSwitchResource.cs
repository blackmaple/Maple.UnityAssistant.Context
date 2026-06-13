using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Resource
{
    public class GameSwitchResource : GameSwitchDisplayDTO, IGameCommonResource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
       
    }
}
