//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ProjectFile.proto
namespace SolasMatch.Proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProjectFile")]
  public partial class ProjectFile : global::ProtoBuf.IExtensible
  {
    public ProjectFile() {}
    

    private int _projectId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"projectId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int projectId
    {
      get { return _projectId; }
      set { _projectId = value; }
    }

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private string _token = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }

    private int _userId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"userId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int userId
    {
      get { return _userId; }
      set { _userId = value; }
    }

    private string _mime = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"mime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string mime
    {
      get { return _mime; }
      set { _mime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}