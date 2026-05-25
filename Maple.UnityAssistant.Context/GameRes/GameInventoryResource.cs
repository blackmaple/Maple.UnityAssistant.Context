using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Context.GameRes
{
    public class GameInventoryResource : GameInventoryDisplayDTO, IGameCommonReource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
        
    }


}
