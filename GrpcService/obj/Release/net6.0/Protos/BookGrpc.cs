// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/book.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Book
  {
    static readonly string __ServiceName = "book.Book";

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
    static readonly grpc::Marshaller<global::GrpcServer.AddBookRequest> __Marshaller_book_AddBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.AddBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.AddBookResponse> __Marshaller_book_AddBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.AddBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.GetBookByIdRequest> __Marshaller_book_GetBookByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.GetBookByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.GetBookResponse> __Marshaller_book_GetBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.GetBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.GetBooksRequest> __Marshaller_book_GetBooksRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.GetBooksRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.GetBooksResponse> __Marshaller_book_GetBooksResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.GetBooksResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.UpdateBookRequest> __Marshaller_book_UpdateBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.UpdateBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.UpdateBookResponse> __Marshaller_book_UpdateBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.UpdateBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.DeleteBookRequest> __Marshaller_book_DeleteBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.DeleteBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.DeleteBookResponse> __Marshaller_book_DeleteBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.DeleteBookResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.AddBookRequest, global::GrpcServer.AddBookResponse> __Method_AddBook = new grpc::Method<global::GrpcServer.AddBookRequest, global::GrpcServer.AddBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddBook",
        __Marshaller_book_AddBookRequest,
        __Marshaller_book_AddBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.GetBookByIdRequest, global::GrpcServer.GetBookResponse> __Method_GetBookById = new grpc::Method<global::GrpcServer.GetBookByIdRequest, global::GrpcServer.GetBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookById",
        __Marshaller_book_GetBookByIdRequest,
        __Marshaller_book_GetBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.GetBooksRequest, global::GrpcServer.GetBooksResponse> __Method_GetBooks = new grpc::Method<global::GrpcServer.GetBooksRequest, global::GrpcServer.GetBooksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBooks",
        __Marshaller_book_GetBooksRequest,
        __Marshaller_book_GetBooksResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.UpdateBookRequest, global::GrpcServer.UpdateBookResponse> __Method_UpdateBook = new grpc::Method<global::GrpcServer.UpdateBookRequest, global::GrpcServer.UpdateBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBook",
        __Marshaller_book_UpdateBookRequest,
        __Marshaller_book_UpdateBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.DeleteBookRequest, global::GrpcServer.DeleteBookResponse> __Method_DeleteBook = new grpc::Method<global::GrpcServer.DeleteBookRequest, global::GrpcServer.DeleteBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBook",
        __Marshaller_book_DeleteBookRequest,
        __Marshaller_book_DeleteBookResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.BookReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Book</summary>
    [grpc::BindServiceMethod(typeof(Book), "BindService")]
    public abstract partial class BookBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.AddBookResponse> AddBook(global::GrpcServer.AddBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.GetBookResponse> GetBookById(global::GrpcServer.GetBookByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.GetBooksResponse> GetBooks(global::GrpcServer.GetBooksRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.UpdateBookResponse> UpdateBook(global::GrpcServer.UpdateBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.DeleteBookResponse> DeleteBook(global::GrpcServer.DeleteBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BookBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddBook, serviceImpl.AddBook)
          .AddMethod(__Method_GetBookById, serviceImpl.GetBookById)
          .AddMethod(__Method_GetBooks, serviceImpl.GetBooks)
          .AddMethod(__Method_UpdateBook, serviceImpl.UpdateBook)
          .AddMethod(__Method_DeleteBook, serviceImpl.DeleteBook).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BookBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.AddBookRequest, global::GrpcServer.AddBookResponse>(serviceImpl.AddBook));
      serviceBinder.AddMethod(__Method_GetBookById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.GetBookByIdRequest, global::GrpcServer.GetBookResponse>(serviceImpl.GetBookById));
      serviceBinder.AddMethod(__Method_GetBooks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.GetBooksRequest, global::GrpcServer.GetBooksResponse>(serviceImpl.GetBooks));
      serviceBinder.AddMethod(__Method_UpdateBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.UpdateBookRequest, global::GrpcServer.UpdateBookResponse>(serviceImpl.UpdateBook));
      serviceBinder.AddMethod(__Method_DeleteBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.DeleteBookRequest, global::GrpcServer.DeleteBookResponse>(serviceImpl.DeleteBook));
    }

  }
}
#endregion