using System.Diagnostics.CodeAnalysis;

namespace Maple.UnityAssistant.Context.UnityHook
{
    public class UnityBlockInputException(string? msg) : Exception(msg)
    {
        [DoesNotReturn]
        public static void Throw(string? msg) => throw new UnityBlockInputException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string? msg) => throw new UnityBlockInputException(msg);


    }
}