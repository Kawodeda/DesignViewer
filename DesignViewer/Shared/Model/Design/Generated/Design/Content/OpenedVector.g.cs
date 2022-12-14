// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: content/opened_vector.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Content {

  /// <summary>Holder for reflection information generated from content/opened_vector.proto</summary>
  public static partial class OpenedVectorReflection {

    #region Descriptor
    /// <summary>File descriptor for content/opened_vector.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenedVectorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtjb250ZW50L29wZW5lZF92ZWN0b3IucHJvdG8SDmRlc2lnbi5jb250ZW50",
            "Gi1jb250ZW50L2NvbnRyb2xzL29wZW5lZF92ZWN0b3JfY29udHJvbHMucHJv",
            "dG8aFGFwcGVhcmFuY2UvcGVuLnByb3RvIncKDE9wZW5lZFZlY3RvchI/Cghj",
            "b250cm9scxgBIAEoCzItLmRlc2lnbi5jb250ZW50LmNvbnRyb2xzLk9wZW5l",
            "ZFZlY3RvckNvbnRyb2xzEiYKBnN0cm9rZRgCIAEoCzIWLmRlc2lnbi5hcHBl",
            "YXJhbmNlLlBlbkIXqgIUTW9kZWwuRGVzaWduLkNvbnRlbnRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Content.Controls.OpenedVectorControlsReflection.Descriptor, global::Model.Design.Appearance.PenReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Content.OpenedVector), global::Model.Design.Content.OpenedVector.Parser, new[]{ "Controls", "Stroke" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An OpenedVector represents an open vector element such as line, broken line,
  /// path etc. It is defined by control points, which define the type of an
  /// opened vector element, and by stroke property, which represents the
  /// appearance of stroke.
  /// </summary>
  public sealed partial class OpenedVector : pb::IMessage<OpenedVector>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OpenedVector> _parser = new pb::MessageParser<OpenedVector>(() => new OpenedVector());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OpenedVector> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Content.OpenedVectorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenedVector() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenedVector(OpenedVector other) : this() {
      controls_ = other.controls_ != null ? other.controls_.Clone() : null;
      stroke_ = other.stroke_ != null ? other.stroke_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenedVector Clone() {
      return new OpenedVector(this);
    }

    /// <summary>Field number for the "controls" field.</summary>
    public const int ControlsFieldNumber = 1;
    private global::Model.Design.Content.Controls.OpenedVectorControls controls_;
    /// <summary>
    /// Contains opened vector's control points.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Content.Controls.OpenedVectorControls Controls {
      get { return controls_; }
      set {
        controls_ = value;
      }
    }

    /// <summary>Field number for the "stroke" field.</summary>
    public const int StrokeFieldNumber = 2;
    private global::Model.Design.Appearance.Pen stroke_;
    /// <summary>
    /// Defines the appearance of stroke.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Pen Stroke {
      get { return stroke_; }
      set {
        stroke_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OpenedVector);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OpenedVector other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Controls, other.Controls)) return false;
      if (!object.Equals(Stroke, other.Stroke)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (controls_ != null) hash ^= Controls.GetHashCode();
      if (stroke_ != null) hash ^= Stroke.GetHashCode();
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
      if (controls_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Controls);
      }
      if (stroke_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Stroke);
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
      if (controls_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Controls);
      }
      if (stroke_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Stroke);
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
      if (controls_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Controls);
      }
      if (stroke_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stroke);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OpenedVector other) {
      if (other == null) {
        return;
      }
      if (other.controls_ != null) {
        if (controls_ == null) {
          Controls = new global::Model.Design.Content.Controls.OpenedVectorControls();
        }
        Controls.MergeFrom(other.Controls);
      }
      if (other.stroke_ != null) {
        if (stroke_ == null) {
          Stroke = new global::Model.Design.Appearance.Pen();
        }
        Stroke.MergeFrom(other.Stroke);
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
            if (controls_ == null) {
              Controls = new global::Model.Design.Content.Controls.OpenedVectorControls();
            }
            input.ReadMessage(Controls);
            break;
          }
          case 18: {
            if (stroke_ == null) {
              Stroke = new global::Model.Design.Appearance.Pen();
            }
            input.ReadMessage(Stroke);
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
            if (controls_ == null) {
              Controls = new global::Model.Design.Content.Controls.OpenedVectorControls();
            }
            input.ReadMessage(Controls);
            break;
          }
          case 18: {
            if (stroke_ == null) {
              Stroke = new global::Model.Design.Appearance.Pen();
            }
            input.ReadMessage(Stroke);
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
