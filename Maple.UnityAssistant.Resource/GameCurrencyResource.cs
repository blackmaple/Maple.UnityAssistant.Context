using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Resource
{
    public class GameCurrencyResource : GameCurrencyDisplayDTO, IGameCommonResource
    {
        public nint ObjectPointer { get; set; }

        public nint ImagePointer { get; set; }
        
    }

}
