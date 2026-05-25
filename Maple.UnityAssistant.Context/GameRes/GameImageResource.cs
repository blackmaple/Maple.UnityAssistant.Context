namespace Maple.UnityAssistant.Context.GameRes
{
    public class GameImageResource
    {

        public required IGameCommonReource CommonReource { get; init; }
        public required nint NativeTexturePtr { get; init; }
        public required float U0 { get; init; }
        public required float U1 { get; init; }
        public required float V0 { get; init; }
        public required float V1 { get; init; }
    }
}
