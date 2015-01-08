// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LoggingInfoModifiedEventResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoggingInfoModifiedEventResponse")]
  public partial class LoggingInfoModifiedEventResponse : global::ProtoBuf.IExtensible
  {
    public LoggingInfoModifiedEventResponse() {}
    

    private bool _enableErrorsLog = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"enableErrorsLog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool enableErrorsLog
    {
      get { return _enableErrorsLog; }
      set { _enableErrorsLog = value; }
    }

    private bool _enableDetailedErrorsLog = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"enableDetailedErrorsLog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool enableDetailedErrorsLog
    {
      get { return _enableDetailedErrorsLog; }
      set { _enableDetailedErrorsLog = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}