//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OrgMembershipAccepted.proto
// Note: requires additional types generated from: EmailMessage.proto
namespace SolasMatch.Proto.email
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrgMembershipAccepted")]
  public partial class OrgMembershipAccepted : global::ProtoBuf.IExtensible
  {
    public OrgMembershipAccepted() {}
    
    private EmailMessage.Type _email_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"email_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public EmailMessage.Type email_type
    {
      get { return _email_type; }
      set { _email_type = value; }
    }
    private int _user_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private int _org_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"org_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int org_id
    {
      get { return _org_id; }
      set { _org_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}