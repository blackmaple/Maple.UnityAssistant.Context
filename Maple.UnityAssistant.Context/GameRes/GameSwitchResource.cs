using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Context.GameRes
{
    public class GameSwitchResource : GameSwitchDisplayDTO, IGameCommonReource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
       
    }
}
