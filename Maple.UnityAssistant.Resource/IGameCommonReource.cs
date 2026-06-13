namespace Maple.UnityAssistant.Resource
{
    public interface IGameCommonResource
    {
        nint ObjectPointer { get; set; }
        nint ImagePointer { get; set; }
        string? DisplayCategory { get; set; }
        string ObjectId { get; set; }
        string? DisplayImage { set; get; }
    }
}
