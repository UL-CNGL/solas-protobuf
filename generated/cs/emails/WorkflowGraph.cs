//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WorkflowGraph.proto
// Note: requires additional types generated from: WorkflowNode.proto
namespace Solas_Match.protos.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowGraph")]
  public partial class WorkflowGraph : global::ProtoBuf.IExtensible
  {
    public WorkflowGraph() {}
    
    private readonly global::System.Collections.Generic.List<WorkflowNode> _rootNode = new global::System.Collections.Generic.List<WorkflowNode>();
    [global::ProtoBuf.ProtoMember(1, Name=@"rootNode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<WorkflowNode> rootNode
    {
      get { return _rootNode; }
    }
  
    private readonly global::System.Collections.Generic.List<WorkflowNode> _allNodes = new global::System.Collections.Generic.List<WorkflowNode>();
    [global::ProtoBuf.ProtoMember(2, Name=@"allNodes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<WorkflowNode> allNodes
    {
      get { return _allNodes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}