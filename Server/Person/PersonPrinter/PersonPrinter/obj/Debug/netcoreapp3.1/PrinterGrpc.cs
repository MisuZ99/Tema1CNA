// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/printer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PersonPrinter {
  public static partial class Printer
  {
    static readonly string __ServiceName = "printer.Printer";

    static readonly grpc::Marshaller<global::PersonPrinter.PrintRequest> __Marshaller_printer_PrintRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PersonPrinter.PrintRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PersonPrinter.PrintReply> __Marshaller_printer_PrintReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PersonPrinter.PrintReply.Parser.ParseFrom);

    static readonly grpc::Method<global::PersonPrinter.PrintRequest, global::PersonPrinter.PrintReply> __Method_PrintPerson = new grpc::Method<global::PersonPrinter.PrintRequest, global::PersonPrinter.PrintReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PrintPerson",
        __Marshaller_printer_PrintRequest,
        __Marshaller_printer_PrintReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PersonPrinter.PrinterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Printer</summary>
    [grpc::BindServiceMethod(typeof(Printer), "BindService")]
    public abstract partial class PrinterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::PersonPrinter.PrintReply> PrintPerson(global::PersonPrinter.PrintRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PrinterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PrintPerson, serviceImpl.PrintPerson).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PrinterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PrintPerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonPrinter.PrintRequest, global::PersonPrinter.PrintReply>(serviceImpl.PrintPerson));
    }

  }
}
#endregion
