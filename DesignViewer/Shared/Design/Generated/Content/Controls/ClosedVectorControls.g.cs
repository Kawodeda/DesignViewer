// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: content/controls/closed_vector_controls.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aurigma.Design.Content.Controls {

  /// <summary>Holder for reflection information generated from content/controls/closed_vector_controls.proto</summary>
  public static partial class ClosedVectorControlsReflection {

    #region Descriptor
    /// <summary>File descriptor for content/controls/closed_vector_controls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClosedVectorControlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1jb250ZW50L2NvbnRyb2xzL2Nsb3NlZF92ZWN0b3JfY29udHJvbHMucHJv",
            "dG8SF2Rlc2lnbi5jb250ZW50LmNvbnRyb2xzGiljb250ZW50L2NvbnRyb2xz",
            "L3JlY3RhbmdsZV9jb250cm9scy5wcm90bxokY29udGVudC9jb250cm9scy9w",
            "YXRoX2NvbnRyb2xzLnByb3RvIpoBChRDbG9zZWRWZWN0b3JDb250cm9scxI/",
            "CglyZWN0YW5nbGUYASABKAsyKi5kZXNpZ24uY29udGVudC5jb250cm9scy5S",
            "ZWN0YW5nbGVDb250cm9sc0gAEjUKBHBhdGgYAiABKAsyJS5kZXNpZ24uY29u",
            "dGVudC5jb250cm9scy5QYXRoQ29udHJvbHNIAEIKCghjb250cm9sc0IiqgIf",
            "QXVyaWdtYS5EZXNpZ24uQ29udGVudC5Db250cm9sc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Aurigma.Design.Content.Controls.RectangleControlsReflection.Descriptor, global::Aurigma.Design.Content.Controls.PathControlsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aurigma.Design.Content.Controls.ClosedVectorControls), global::Aurigma.Design.Content.Controls.ClosedVectorControls.Parser, new[]{ "Rectangle", "Path" }, new[]{ "Controls" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClosedVectorControls : pb::IMessage<ClosedVectorControls>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClosedVectorControls> _parser = new pb::MessageParser<ClosedVectorControls>(() => new ClosedVectorControls());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClosedVectorControls> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aurigma.Design.Content.Controls.ClosedVectorControlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClosedVectorControls() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClosedVectorControls(ClosedVectorControls other) : this() {
      switch (other.ControlsCase) {
        case ControlsOneofCase.Rectangle:
          Rectangle = other.Rectangle.Clone();
          break;
        case ControlsOneofCase.Path:
          Path = other.Path.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClosedVectorControls Clone() {
      return new ClosedVectorControls(this);
    }

    /// <summary>Field number for the "rectangle" field.</summary>
    public const int RectangleFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.Content.Controls.RectangleControls Rectangle {
      get { return controlsCase_ == ControlsOneofCase.Rectangle ? (global::Aurigma.Design.Content.Controls.RectangleControls) controls_ : null; }
      set {
        controls_ = value;
        controlsCase_ = value == null ? ControlsOneofCase.None : ControlsOneofCase.Rectangle;
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.Content.Controls.PathControls Path {
      get { return controlsCase_ == ControlsOneofCase.Path ? (global::Aurigma.Design.Content.Controls.PathControls) controls_ : null; }
      set {
        controls_ = value;
        controlsCase_ = value == null ? ControlsOneofCase.None : ControlsOneofCase.Path;
      }
    }

    private object controls_;
    /// <summary>Enum of possible cases for the "controls" oneof.</summary>
    public enum ControlsOneofCase {
      None = 0,
      Rectangle = 1,
      Path = 2,
    }
    private ControlsOneofCase controlsCase_ = ControlsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ControlsOneofCase ControlsCase {
      get { return controlsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearControls() {
      controlsCase_ = ControlsOneofCase.None;
      controls_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClosedVectorControls);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClosedVectorControls other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Rectangle, other.Rectangle)) return false;
      if (!object.Equals(Path, other.Path)) return false;
      if (ControlsCase != other.ControlsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (controlsCase_ == ControlsOneofCase.Rectangle) hash ^= Rectangle.GetHashCode();
      if (controlsCase_ == ControlsOneofCase.Path) hash ^= Path.GetHashCode();
      hash ^= (int) controlsCase_;
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
      if (controlsCase_ == ControlsOneofCase.Rectangle) {
        output.WriteRawTag(10);
        output.WriteMessage(Rectangle);
      }
      if (controlsCase_ == ControlsOneofCase.Path) {
        output.WriteRawTag(18);
        output.WriteMessage(Path);
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
      if (controlsCase_ == ControlsOneofCase.Rectangle) {
        output.WriteRawTag(10);
        output.WriteMessage(Rectangle);
      }
      if (controlsCase_ == ControlsOneofCase.Path) {
        output.WriteRawTag(18);
        output.WriteMessage(Path);
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
      if (controlsCase_ == ControlsOneofCase.Rectangle) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rectangle);
      }
      if (controlsCase_ == ControlsOneofCase.Path) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Path);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClosedVectorControls other) {
      if (other == null) {
        return;
      }
      switch (other.ControlsCase) {
        case ControlsOneofCase.Rectangle:
          if (Rectangle == null) {
            Rectangle = new global::Aurigma.Design.Content.Controls.RectangleControls();
          }
          Rectangle.MergeFrom(other.Rectangle);
          break;
        case ControlsOneofCase.Path:
          if (Path == null) {
            Path = new global::Aurigma.Design.Content.Controls.PathControls();
          }
          Path.MergeFrom(other.Path);
          break;
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
            global::Aurigma.Design.Content.Controls.RectangleControls subBuilder = new global::Aurigma.Design.Content.Controls.RectangleControls();
            if (controlsCase_ == ControlsOneofCase.Rectangle) {
              subBuilder.MergeFrom(Rectangle);
            }
            input.ReadMessage(subBuilder);
            Rectangle = subBuilder;
            break;
          }
          case 18: {
            global::Aurigma.Design.Content.Controls.PathControls subBuilder = new global::Aurigma.Design.Content.Controls.PathControls();
            if (controlsCase_ == ControlsOneofCase.Path) {
              subBuilder.MergeFrom(Path);
            }
            input.ReadMessage(subBuilder);
            Path = subBuilder;
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
            global::Aurigma.Design.Content.Controls.RectangleControls subBuilder = new global::Aurigma.Design.Content.Controls.RectangleControls();
            if (controlsCase_ == ControlsOneofCase.Rectangle) {
              subBuilder.MergeFrom(Rectangle);
            }
            input.ReadMessage(subBuilder);
            Rectangle = subBuilder;
            break;
          }
          case 18: {
            global::Aurigma.Design.Content.Controls.PathControls subBuilder = new global::Aurigma.Design.Content.Controls.PathControls();
            if (controlsCase_ == ControlsOneofCase.Path) {
              subBuilder.MergeFrom(Path);
            }
            input.ReadMessage(subBuilder);
            Path = subBuilder;
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
