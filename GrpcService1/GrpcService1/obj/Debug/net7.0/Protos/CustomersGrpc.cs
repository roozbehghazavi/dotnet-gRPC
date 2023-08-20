// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService1 {
  public static partial class CustomerService
  {
    static readonly string __ServiceName = "CustomerService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService1.ProtoCustomer> __Marshaller_ProtoCustomer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.ProtoCustomer.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService1.ProtoEmpty> __Marshaller_ProtoEmpty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.ProtoEmpty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService1.CustomerRequest> __Marshaller_CustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.CustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService1.CustomerAgeResponse> __Marshaller_CustomerAgeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.CustomerAgeResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService1.CustomersListResponse> __Marshaller_CustomersListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService1.CustomersListResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService1.ProtoCustomer, global::GrpcService1.ProtoEmpty> __Method_AddCustomer = new grpc::Method<global::GrpcService1.ProtoCustomer, global::GrpcService1.ProtoEmpty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCustomer",
        __Marshaller_ProtoCustomer,
        __Marshaller_ProtoEmpty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService1.CustomerRequest, global::GrpcService1.CustomerAgeResponse> __Method_GetCustomerAge = new grpc::Method<global::GrpcService1.CustomerRequest, global::GrpcService1.CustomerAgeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerAge",
        __Marshaller_CustomerRequest,
        __Marshaller_CustomerAgeResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService1.ProtoEmpty, global::GrpcService1.CustomersListResponse> __Method_GetCustomersList = new grpc::Method<global::GrpcService1.ProtoEmpty, global::GrpcService1.CustomersListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomersList",
        __Marshaller_ProtoEmpty,
        __Marshaller_CustomersListResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService1.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerService</summary>
    [grpc::BindServiceMethod(typeof(CustomerService), "BindService")]
    public abstract partial class CustomerServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService1.ProtoEmpty> AddCustomer(global::GrpcService1.ProtoCustomer request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService1.CustomerAgeResponse> GetCustomerAge(global::GrpcService1.CustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService1.CustomersListResponse> GetCustomersList(global::GrpcService1.ProtoEmpty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CustomerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddCustomer, serviceImpl.AddCustomer)
          .AddMethod(__Method_GetCustomerAge, serviceImpl.GetCustomerAge)
          .AddMethod(__Method_GetCustomersList, serviceImpl.GetCustomersList).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService1.ProtoCustomer, global::GrpcService1.ProtoEmpty>(serviceImpl.AddCustomer));
      serviceBinder.AddMethod(__Method_GetCustomerAge, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService1.CustomerRequest, global::GrpcService1.CustomerAgeResponse>(serviceImpl.GetCustomerAge));
      serviceBinder.AddMethod(__Method_GetCustomersList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService1.ProtoEmpty, global::GrpcService1.CustomersListResponse>(serviceImpl.GetCustomersList));
    }

  }
}
#endregion
