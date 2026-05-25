namespace Maple.UnityAssistant.Context.GameRes
{
    public interface IGameCommonReource
    {
        nint ObjectPointer { get; set; }
        nint ImagePointer { get; set; }
        string? DisplayCategory { get; set; }
        string ObjectId { get; set; }
        string? DisplayImage { set; get; }
    }
}
