//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ArchivedTask.proto
namespace SolasMatch.Proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ArchivedTask")]
  public partial class ArchivedTask : global::ProtoBuf.IExtensible
  {
    public ArchivedTask() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }

    private int _projectId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"projectId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int projectId
    {
      get { return _projectId; }
      set { _projectId = value; }
    }

    private string _title = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }

    private string _comment = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string comment
    {
      get { return _comment; }
      set { _comment = value; }
    }

    private string _deadline = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"deadline", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string deadline
    {
      get { return _deadline; }
      set { _deadline = value; }
    }

    private int _wordCount = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"wordCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int wordCount
    {
      get { return _wordCount; }
      set { _wordCount = value; }
    }

    private string _createdTime = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"createdTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string createdTime
    {
      get { return _createdTime; }
      set { _createdTime = value; }
    }

    private string _sourceLanguageCode = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sourceLanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sourceLanguageCode
    {
      get { return _sourceLanguageCode; }
      set { _sourceLanguageCode = value; }
    }

    private string _targetLanguageCode = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"targetLanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string targetLanguageCode
    {
      get { return _targetLanguageCode; }
      set { _targetLanguageCode = value; }
    }

    private string _sourceCountryCode = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"sourceCountryCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sourceCountryCode
    {
      get { return _sourceCountryCode; }
      set { _sourceCountryCode = value; }
    }

    private string _targetCountryCode = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"targetCountryCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string targetCountryCode
    {
      get { return _targetCountryCode; }
      set { _targetCountryCode = value; }
    }

    private string _taskType = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"taskType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string taskType
    {
      get { return _taskType; }
      set { _taskType = value; }
    }

    private string _taskStatus = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"taskStatus", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string taskStatus
    {
      get { return _taskStatus; }
      set { _taskStatus = value; }
    }

    private bool _published = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"published", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool published
    {
      get { return _published; }
      set { _published = value; }
    }

    private int _translatorId = default(int);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"translatorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int translatorId
    {
      get { return _translatorId; }
      set { _translatorId = value; }
    }

    private int _archiveUserId = default(int);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"archiveUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int archiveUserId
    {
      get { return _archiveUserId; }
      set { _archiveUserId = value; }
    }

    private string _archiveDate = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"archiveDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string archiveDate
    {
      get { return _archiveDate; }
      set { _archiveDate = value; }
    }

    private string _tags = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"tags", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tags
    {
      get { return _tags; }
      set { _tags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}