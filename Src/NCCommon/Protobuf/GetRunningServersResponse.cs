//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetRunningServersResponse.proto
// Note: requires additional types generated from: KeyValuePair.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetRunningServersResponse")]
  public partial class GetRunningServersResponse : global::ProtoBuf.IExtensible
  {
    public GetRunningServersResponse() {}
    
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair> _keyValuePair = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keyValuePair", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair> keyValuePair
    {
      get { return _keyValuePair; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair> _connectedClients = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair>();
    [global::ProtoBuf.ProtoMember(2, Name=@"connectedClients", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValuePair> connectedClients
    {
      get { return _connectedClients; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
