using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
using Maple.XScheduler;
using Microsoft.Extensions.Logging;
namespace Maple.UnityAssistant.Demo;

public sealed class DemoContextService(
    ILogger<DemoContextService> logger,
    MonoRuntimeContext runtimeContext,
    MonoTaskScheduler taskScheduler,
    WinMsgHookFactory winMsgHookFactory,
    MonoInternalCallService internalCallService,
     MonoGameSettings gameSettings,
    IHookFactory hookFactory,
    IXSchedulerFactory schedulerFactory)
    : GameContextService<DemoMetadataContext>(logger, runtimeContext, taskScheduler, winMsgHookFactory, internalCallService, gameSettings, hookFactory, schedulerFactory)
{


    protected override DemoMetadataContext LoadContextMetadata()
    {
       // return default!;
        //foreach (var dic in InternalCallService.InternalCalls)
        //{
        //    this.Logger.LogInformation("InternalCall: {Key} - {Value:X8}", dic.Key, dic.Value);
        //}

        var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
        searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
        {
            Classes = DemoMetadataContext.MonoJsonClassDTO,
            Methods = DemoMetadataContext.MonoJsonMethodDTO,
            Fields = DemoMetadataContext.MonoJsonFieldDTO,
        });
        return new DemoMetadataContext(Logger, searchService, RuntimeContext);
    }


    protected override ValueTask LoadGameResourcesAsync()
    {
        return ValueTask.CompletedTask;
       // throw new NotImplementedException();
    }


   


}

 