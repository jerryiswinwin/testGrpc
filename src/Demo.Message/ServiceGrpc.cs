// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Demo.Message {
  public static partial class DemoService
  {
    static readonly string __ServiceName = "Demo.Message.DemoService";

    static readonly grpc::Marshaller<global::Demo.Message.GreetingMsg> __Marshaller_Demo_Message_GreetingMsg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Message.GreetingMsg.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo.Message.GreetingResponse> __Marshaller_Demo_Message_GreetingResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Message.GreetingResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo.Message.EmptyMsg> __Marshaller_Demo_Message_EmptyMsg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Message.EmptyMsg.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo.Message.TestResponse> __Marshaller_Demo_Message_TestResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Message.TestResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Demo.Message.GreetingMsg, global::Demo.Message.GreetingResponse> __Method_Say = new grpc::Method<global::Demo.Message.GreetingMsg, global::Demo.Message.GreetingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Say",
        __Marshaller_Demo_Message_GreetingMsg,
        __Marshaller_Demo_Message_GreetingResponse);

    static readonly grpc::Method<global::Demo.Message.EmptyMsg, global::Demo.Message.TestResponse> __Method_TestWithEmpty = new grpc::Method<global::Demo.Message.EmptyMsg, global::Demo.Message.TestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestWithEmpty",
        __Marshaller_Demo_Message_EmptyMsg,
        __Marshaller_Demo_Message_TestResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Demo.Message.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DemoService</summary>
    [grpc::BindServiceMethod(typeof(DemoService), "BindService")]
    public abstract partial class DemoServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Demo.Message.GreetingResponse> Say(global::Demo.Message.GreetingMsg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo.Message.TestResponse> TestWithEmpty(global::Demo.Message.EmptyMsg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DemoService</summary>
    public partial class DemoServiceClient : grpc::ClientBase<DemoServiceClient>
    {
      /// <summary>Creates a new client for DemoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DemoServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DemoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DemoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DemoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DemoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Demo.Message.GreetingResponse Say(global::Demo.Message.GreetingMsg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Say(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo.Message.GreetingResponse Say(global::Demo.Message.GreetingMsg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Say, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo.Message.GreetingResponse> SayAsync(global::Demo.Message.GreetingMsg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo.Message.GreetingResponse> SayAsync(global::Demo.Message.GreetingMsg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Say, null, options, request);
      }
      public virtual global::Demo.Message.TestResponse TestWithEmpty(global::Demo.Message.EmptyMsg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestWithEmpty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo.Message.TestResponse TestWithEmpty(global::Demo.Message.EmptyMsg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TestWithEmpty, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo.Message.TestResponse> TestWithEmptyAsync(global::Demo.Message.EmptyMsg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestWithEmptyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo.Message.TestResponse> TestWithEmptyAsync(global::Demo.Message.EmptyMsg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TestWithEmpty, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DemoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DemoServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DemoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Say, serviceImpl.Say)
          .AddMethod(__Method_TestWithEmpty, serviceImpl.TestWithEmpty).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DemoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Say, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo.Message.GreetingMsg, global::Demo.Message.GreetingResponse>(serviceImpl.Say));
      serviceBinder.AddMethod(__Method_TestWithEmpty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo.Message.EmptyMsg, global::Demo.Message.TestResponse>(serviceImpl.TestWithEmpty));
    }

  }
}
#endregion