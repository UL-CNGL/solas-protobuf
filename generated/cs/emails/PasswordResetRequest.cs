//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PasswordResetRequest.proto
namespace Solas_Match.protos.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PasswordResetRequest")]
  public partial class PasswordResetRequest : global::ProtoBuf.IExtensible
  {
    public PasswordResetRequest() {}
    

    private int _user_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private string _requestTime = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"requestTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string requestTime
    {
      get { return _requestTime; }
      set { _requestTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}