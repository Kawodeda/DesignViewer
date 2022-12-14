// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: content/controls/rectangle_controls.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Content.Controls {

  /// <summary>Holder for reflection information generated from content/controls/rectangle_controls.proto</summary>
  public static partial class RectangleControlsReflection {

    #region Descriptor
    /// <summary>File descriptor for content/controls/rectangle_controls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RectangleControlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciljb250ZW50L2NvbnRyb2xzL3JlY3RhbmdsZV9jb250cm9scy5wcm90bxIX",
            "ZGVzaWduLmNvbnRlbnQuY29udHJvbHMaEG1hdGgvcG9pbnQucHJvdG8iXQoR",
            "UmVjdGFuZ2xlQ29udHJvbHMSIwoHY29ybmVyMRgBIAEoCzISLmRlc2lnbi5t",
            "YXRoLlBvaW50EiMKB2Nvcm5lcjIYAiABKAsyEi5kZXNpZ24ubWF0aC5Qb2lu",
            "dEIgqgIdTW9kZWwuRGVzaWduLkNvbnRlbnQuQ29udHJvbHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Math.PointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Content.Controls.RectangleControls), global::Model.Design.Content.Controls.RectangleControls.Parser, new[]{ "Corner1", "Corner2" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A RectangleControls represents a two-dimensional rectangle defined by its
  /// corner points: the top-left corner point and the bottom-right one.
  /// </summary>
  public sealed partial class RectangleControls : pb::IMessage<RectangleControls>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RectangleControls> _parser = new pb::MessageParser<RectangleControls>(() => new RectangleControls());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RectangleControls> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Content.Controls.RectangleControlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RectangleControls() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RectangleControls(RectangleControls other) : this() {
      corner1_ = other.corner1_ != null ? other.corner1_.Clone() : null;
      corner2_ = other.corner2_ != null ? other.corner2_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RectangleControls Clone() {
      return new RectangleControls(this);
    }

    /// <summary>Field number for the "corner1" field.</summary>
    public const int Corner1FieldNumber = 1;
    private global::Model.Design.Math.Point corner1_;
    /// <summary>
    /// Represents the top-left corner of a rectangle
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Math.Point Corner1 {
      get { return corner1_; }
      set {
        corner1_ = value;
      }
    }

    /// <summary>Field number for the "corner2" field.</summary>
    public const int Corner2FieldNumber = 2;
    private global::Model.Design.Math.Point corner2_;
    /// <summary>
    /// Represents the bootom-right corner of a rectangle
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Math.Point Corner2 {
      get { return corner2_; }
      set {
        corner2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RectangleControls);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RectangleControls other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Corner1, other.Corner1)) return false;
      if (!object.Equals(Corner2, other.Corner2)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (corner1_ != null) hash ^= Corner1.GetHashCode();
      if (corner2_ != null) hash ^= Corner2.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (corner1_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Corner1);
      }
      if (corner2_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Corner2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (corner1_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Corner1);
      }
      if (corner2_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Corner2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (corner1_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Corner1);
      }
      if (corner2_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Corner2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RectangleControls other) {
      if (other == null) {
        return;
      }
      if (other.corner1_ != null) {
        if (corner1_ == null) {
          Corner1 = new global::Model.Design.Math.Point();
        }
        Corner1.MergeFrom(other.Corner1);
      }
      if (other.corner2_ != null) {
        if (corner2_ == null) {
          Corner2 = new global::Model.Design.Math.Point();
        }
        Corner2.MergeFrom(other.Corner2);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (corner1_ == null) {
              Corner1 = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Corner1);
            break;
          }
          case 18: {
            if (corner2_ == null) {
              Corner2 = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Corner2);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (corner1_ == null) {
              Corner1 = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Corner1);
            break;
          }
          case 18: {
            if (corner2_ == null) {
              Corner2 = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Corner2);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
