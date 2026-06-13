using Maple.MonoGameAssistant.GameDTO;

namespace Maple.UnityAssistant.Resource
{
    public class GameSkillResource : GameSkillDisplayDTO, IGameCommonResource
    {
        public nint ObjectPointer { get; set; }
        public nint ImagePointer { get; set; }
       

    }


}
