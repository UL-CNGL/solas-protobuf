//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: User.proto
namespace Solas_Match.protos.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"User")]
  public partial class User : global::ProtoBuf.IExtensible
  {
    public User() {}
    

    private int _user_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }

    private string _display_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"display_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string display_name
    {
      get { return _display_name; }
      set { _display_name = value; }
    }

    private string _email = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"email", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string email
    {
      get { return _email; }
      set { _email = value; }
    }

    private string _password = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }

    private string _biography = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"biography", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string biography
    {
      get { return _biography; }
      set { _biography = value; }
    }

    private string _nonce = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"nonce", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nonce
    {
      get { return _nonce; }
      set { _nonce = value; }
    }

    private string _created_time = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"created_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string created_time
    {
      get { return _created_time; }
      set { _created_time = value; }
    }

    private int _native_lang_id = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"native_lang_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int native_lang_id
    {
      get { return _native_lang_id; }
      set { _native_lang_id = value; }
    }

    private int _native_region_id = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"native_region_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int native_region_id
    {
      get { return _native_region_id; }
      set { _native_region_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}