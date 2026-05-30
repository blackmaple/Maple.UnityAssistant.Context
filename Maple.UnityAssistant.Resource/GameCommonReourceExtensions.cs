//using Maple.MonoGameAssistant.GameDTO;
//using Maple.MonoGameAssistant.MetadataCollections;
//using Maple.MonoGameAssistant.Model;
//using Maple.UnmanagedExtensions;
//using System.Runtime.CompilerServices;

//namespace Maple.UnityAssistant.Resource
//{
//    public static class GameCommonReourceExtensions
//    {
//        public static IEnumerable<GameCurrencyResource> LoadCurrencyResources<TKEY, TVALUE>(
//            this SysPtrDictionary<TKEY, TVALUE> @this,
//            Func<TKEY, TVALUE, GameCurrencyResource> func_getObject,
//            Func<TKEY, TVALUE, string> func_getName,
//            Func<TKEY, TVALUE, string> func_getDesc,
//            Func<TKEY, TVALUE, string> func_getCategory,
//            Func<TKEY, TVALUE, string> func_getImage,

//            Action<TKEY, TVALUE, GameCurrencyResource>? action_Extra = default,
//            Func<TKEY, TVALUE, bool>? skip = default)
//            where TKEY : unmanaged
//            where TVALUE : unmanaged
//        {
//            return @this.LoadResources(func_getObject, func_getName, func_getDesc, func_getCategory, func_getImage, action_Extra, skip);
//        }

//        public static IEnumerable<GameInventoryResource> LoadInventoryResources<TKEY, TVALUE>(
//            this SysPtrDictionary<TKEY, TVALUE> @this,
//            Func<TKEY, TVALUE, GameInventoryResource> func_getObject,
//            Func<TKEY, TVALUE, string> func_getName,
//            Func<TKEY, TVALUE, string> func_getDesc,
//            Func<TKEY, TVALUE, string> func_getCategory,
//            Func<TKEY, TVALUE, string> func_getImage,

//            Action<TKEY, TVALUE, GameInventoryResource>? action_Extra = default,
//            Func<TKEY, TVALUE, bool>? skip = default)
//            where TKEY : unmanaged
//            where TVALUE : unmanaged
//        {
//            return @this.LoadResources(func_getObject, func_getName, func_getDesc, func_getCategory, func_getImage, action_Extra, skip);

//        }
//        public static IEnumerable<TRES> LoadResources<TKEY, TVALUE, TRES>(
//            this SysPtrDictionary<TKEY, TVALUE> @this,
//            Func<TKEY, TVALUE, TRES> func_getObject,
//            Func<TKEY, TVALUE, string> func_getName,
//            Func<TKEY, TVALUE, string> func_getDesc,
//            Func<TKEY, TVALUE, string> func_getCategory,
//            Func<TKEY, TVALUE, string> func_getImage,

//            Action<TKEY, TVALUE, TRES>? action_Extra = default,
//            Func<TKEY, TVALUE, bool>? skip = default)
//            where TKEY : unmanaged
//            where TVALUE : unmanaged
//            where TRES : GameObjectDisplayDTO
//        {
//            var enumerable =
//                skip is not null
//                ? @this.AsRefEnumerable().Where(p => !skip(p.Key, p.Value))
//                : @this.AsRefEnumerable();


//            foreach (var item in enumerable)
//            {
//                var resource = func_getObject(item.Key, item.Value);
//                resource.DisplayCategory = func_getCategory(item.Key, item.Value);
//                resource.DisplayName = func_getName(item.Key, item.Value);
//                resource.DisplayDesc = func_getDesc(item.Key, item.Value);
//                resource.DisplayImage = func_getImage(item.Key, item.Value);
//                action_Extra?.Invoke(item.Key, item.Value, resource);
//                yield return resource;
//            }
//        }


//        public static IEnumerable<TRES> LoadResources<TVALUE, TRES>(
//            this SysPtrList<TVALUE> @this,
//            Func<TVALUE, TRES> func_getObject,
//            Func<TVALUE, string> func_getName,
//            Func<TVALUE, string> func_getDesc,
//            Func<TVALUE, string> func_getCategory,
//            Func<TVALUE, string> func_getImage,

//            Action<TVALUE, TRES>? action_Extra = default,
//            Func<TVALUE, bool>? skip = default)

//            where TVALUE : unmanaged
//            where TRES : GameObjectDisplayDTO
//        {
//            var enumerable =
//                skip is not null
//                ? @this.AsEnumerable().Where(p => !skip(p))
//                : @this.AsEnumerable();


//            foreach (var item in enumerable)
//            {
//                var resource = func_getObject(item );
//                resource.DisplayCategory = func_getCategory(item);
//                resource.DisplayName = func_getName(item);
//                resource.DisplayDesc = func_getDesc(item);
//                resource.DisplayImage = func_getImage(item);
//                action_Extra?.Invoke(item, resource);
//                yield return resource;
//            }
//        }
//    }
//}
