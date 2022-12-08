// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: appearance/color/color.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Appearance.Color {

  /// <summary>Holder for reflection information generated from appearance/color/color.proto</summary>
  public static partial class ColorReflection {

    #region Descriptor
    /// <summary>File descriptor for appearance/color/color.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxhcHBlYXJhbmNlL2NvbG9yL2NvbG9yLnByb3RvEhdkZXNpZ24uYXBwZWFy",
            "YW5jZS5jb2xvchohYXBwZWFyYW5jZS9jb2xvci9zcG90X2NvbG9yLnByb3Rv",
            "GiRhcHBlYXJhbmNlL2NvbG9yL3Byb2Nlc3NfY29sb3IucHJvdG8ifgoFQ29s",
            "b3ISOAoHcHJvY2VzcxgBIAEoCzIlLmRlc2lnbi5hcHBlYXJhbmNlLmNvbG9y",
            "LlByb2Nlc3NDb2xvckgAEjIKBHNwb3QYAiABKAsyIi5kZXNpZ24uYXBwZWFy",
            "YW5jZS5jb2xvci5TcG90Q29sb3JIAEIHCgV2YWx1ZUIgqgIdTW9kZWwuRGVz",
            "aWduLkFwcGVhcmFuY2UuQ29sb3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Appearance.Color.SpotColorReflection.Descriptor, global::Model.Design.Appearance.Color.ProcessColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Appearance.Color.Color), global::Model.Design.Appearance.Color.Color.Parser, new[]{ "Process", "Spot" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Color : pb::IMessage<Color>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Color> _parser = new pb::MessageParser<Color>(() => new Color());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Color> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Appearance.Color.ColorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Color() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Color(Color other) : this() {
      switch (other.ValueCase) {
        case ValueOneofCase.Process:
          Process = other.Process.Clone();
          break;
        case ValueOneofCase.Spot:
          Spot = other.Spot.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Color Clone() {
      return new Color(this);
    }

    /// <summary>Field number for the "process" field.</summary>
    public const int ProcessFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Color.ProcessColor Process {
      get { return valueCase_ == ValueOneofCase.Process ? (global::Model.Design.Appearance.Color.ProcessColor) value_ : null; }
      set {
        value_ = value;
        valueCase_ = value == null ? ValueOneofCase.None : ValueOneofCase.Process;
      }
    }

    /// <summary>Field number for the "spot" field.</summary>
    public const int SpotFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Color.SpotColor Spot {
      get { return valueCase_ == ValueOneofCase.Spot ? (global::Model.Design.Appearance.Color.SpotColor) value_ : null; }
      set {
        value_ = value;
        valueCase_ = value == null ? ValueOneofCase.None : ValueOneofCase.Spot;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      Process = 1,
      Spot = 2,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Color);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Color other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Process, other.Process)) return false;
      if (!object.Equals(Spot, other.Spot)) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (valueCase_ == ValueOneofCase.Process) hash ^= Process.GetHashCode();
      if (valueCase_ == ValueOneofCase.Spot) hash ^= Spot.GetHashCode();
      hash ^= (int) valueCase_;
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
      if (valueCase_ == ValueOneofCase.Process) {
        output.WriteRawTag(10);
        output.WriteMessage(Process);
      }
      if (valueCase_ == ValueOneofCase.Spot) {
        output.WriteRawTag(18);
        output.WriteMessage(Spot);
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
      if (valueCase_ == ValueOneofCase.Process) {
        output.WriteRawTag(10);
        output.WriteMessage(Process);
      }
      if (valueCase_ == ValueOneofCase.Spot) {
        output.WriteRawTag(18);
        output.WriteMessage(Spot);
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
      if (valueCase_ == ValueOneofCase.Process) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Process);
      }
      if (valueCase_ == ValueOneofCase.Spot) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Spot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Color other) {
      if (other == null) {
        return;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.Process:
          if (Process == null) {
            Process = new global::Model.Design.Appearance.Color.ProcessColor();
          }
          Process.MergeFrom(other.Process);
          break;
        case ValueOneofCase.Spot:
          if (Spot == null) {
            Spot = new global::Model.Design.Appearance.Color.SpotColor();
          }
          Spot.MergeFrom(other.Spot);
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
            global::Model.Design.Appearance.Color.ProcessColor subBuilder = new global::Model.Design.Appearance.Color.ProcessColor();
            if (valueCase_ == ValueOneofCase.Process) {
              subBuilder.MergeFrom(Process);
            }
            input.ReadMessage(subBuilder);
            Process = subBuilder;
            break;
          }
          case 18: {
            global::Model.Design.Appearance.Color.SpotColor subBuilder = new global::Model.Design.Appearance.Color.SpotColor();
            if (valueCase_ == ValueOneofCase.Spot) {
              subBuilder.MergeFrom(Spot);
            }
            input.ReadMessage(subBuilder);
            Spot = subBuilder;
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
            global::Model.Design.Appearance.Color.ProcessColor subBuilder = new global::Model.Design.Appearance.Color.ProcessColor();
            if (valueCase_ == ValueOneofCase.Process) {
              subBuilder.MergeFrom(Process);
            }
            input.ReadMessage(subBuilder);
            Process = subBuilder;
            break;
          }
          case 18: {
            global::Model.Design.Appearance.Color.SpotColor subBuilder = new global::Model.Design.Appearance.Color.SpotColor();
            if (valueCase_ == ValueOneofCase.Spot) {
              subBuilder.MergeFrom(Spot);
            }
            input.ReadMessage(subBuilder);
            Spot = subBuilder;
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