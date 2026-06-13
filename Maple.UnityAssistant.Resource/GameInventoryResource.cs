using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Resource
{
    public class GameInventoryResource : GameInventoryDisplayDTO, IGameCommonResource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
        
    }


}
