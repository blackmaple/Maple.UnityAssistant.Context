using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Context.GameRes
{
    public class GameMonsterResource : GameMonsterDisplayDTO, IGameCommonReource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
      

    }


}
