// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: appearance/color/process_color.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Appearance.Color {

  /// <summary>Holder for reflection information generated from appearance/color/process_color.proto</summary>
  public static partial class ProcessColorReflection {

    #region Descriptor
    /// <summary>File descriptor for appearance/color/process_color.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProcessColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRhcHBlYXJhbmNlL2NvbG9yL3Byb2Nlc3NfY29sb3IucHJvdG8SF2Rlc2ln",
            "bi5hcHBlYXJhbmNlLmNvbG9yGiFhcHBlYXJhbmNlL2NvbG9yL2NteWtfY29s",
            "b3IucHJvdG8aIGFwcGVhcmFuY2UvY29sb3IvcmdiX2NvbG9yLnByb3RvIowB",
            "CgxQcm9jZXNzQ29sb3ISDQoFYWxwaGEYASABKA0SMAoDcmdiGAIgASgLMiEu",
            "ZGVzaWduLmFwcGVhcmFuY2UuY29sb3IuUmdiQ29sb3JIABIyCgRjbXlrGAMg",
            "ASgLMiIuZGVzaWduLmFwcGVhcmFuY2UuY29sb3IuQ215a0NvbG9ySABCBwoF",
            "dmFsdWVCIKoCHU1vZGVsLkRlc2lnbi5BcHBlYXJhbmNlLkNvbG9yYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Appearance.Color.CmykColorReflection.Descriptor, global::Model.Design.Appearance.Color.RgbColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Appearance.Color.ProcessColor), global::Model.Design.Appearance.Color.ProcessColor.Parser, new[]{ "Alpha", "Rgb", "Cmyk" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProcessColor : pb::IMessage<ProcessColor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProcessColor> _parser = new pb::MessageParser<ProcessColor>(() => new ProcessColor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProcessColor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Appearance.Color.ProcessColorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessColor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessColor(ProcessColor other) : this() {
      alpha_ = other.alpha_;
      switch (other.ValueCase) {
        case ValueOneofCase.Rgb:
          Rgb = other.Rgb.Clone();
          break;
        case ValueOneofCase.Cmyk:
          Cmyk = other.Cmyk.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessColor Clone() {
      return new ProcessColor(this);
    }

    /// <summary>Field number for the "alpha" field.</summary>
    public const int AlphaFieldNumber = 1;
    private uint alpha_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Alpha {
      get { return alpha_; }
      set {
        alpha_ = value;
      }
    }

    /// <summary>Field number for the "rgb" field.</summary>
    public const int RgbFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Color.RgbColor Rgb {
      get { return valueCase_ == ValueOneofCase.Rgb ? (global::Model.Design.Appearance.Color.RgbColor) value_ : null; }
      set {
        value_ = value;
        valueCase_ = value == null ? ValueOneofCase.None : ValueOneofCase.Rgb;
      }
    }

    /// <summary>Field number for the "cmyk" field.</summary>
    public const int CmykFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Color.CmykColor Cmyk {
      get { return valueCase_ == ValueOneofCase.Cmyk ? (global::Model.Design.Appearance.Color.CmykColor) value_ : null; }
      set {
        value_ = value;
        valueCase_ = value == null ? ValueOneofCase.None : ValueOneofCase.Cmyk;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      Rgb = 2,
      Cmyk = 3,
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
      return Equals(other as ProcessColor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProcessColor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Alpha != other.Alpha) return false;
      if (!object.Equals(Rgb, other.Rgb)) return false;
      if (!object.Equals(Cmyk, other.Cmyk)) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Alpha != 0) hash ^= Alpha.GetHashCode();
      if (valueCase_ == ValueOneofCase.Rgb) hash ^= Rgb.GetHashCode();
      if (valueCase_ == ValueOneofCase.Cmyk) hash ^= Cmyk.GetHashCode();
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
      if (Alpha != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Alpha);
      }
      if (valueCase_ == ValueOneofCase.Rgb) {
        output.WriteRawTag(18);
        output.WriteMessage(Rgb);
      }
      if (valueCase_ == ValueOneofCase.Cmyk) {
        output.WriteRawTag(26);
        output.WriteMessage(Cmyk);
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
      if (Alpha != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Alpha);
      }
      if (valueCase_ == ValueOneofCase.Rgb) {
        output.WriteRawTag(18);
        output.WriteMessage(Rgb);
      }
      if (valueCase_ == ValueOneofCase.Cmyk) {
        output.WriteRawTag(26);
        output.WriteMessage(Cmyk);
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
      if (Alpha != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Alpha);
      }
      if (valueCase_ == ValueOneofCase.Rgb) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rgb);
      }
      if (valueCase_ == ValueOneofCase.Cmyk) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cmyk);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProcessColor other) {
      if (other == null) {
        return;
      }
      if (other.Alpha != 0) {
        Alpha = other.Alpha;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.Rgb:
          if (Rgb == null) {
            Rgb = new global::Model.Design.Appearance.Color.RgbColor();
          }
          Rgb.MergeFrom(other.Rgb);
          break;
        case ValueOneofCase.Cmyk:
          if (Cmyk == null) {
            Cmyk = new global::Model.Design.Appearance.Color.CmykColor();
          }
          Cmyk.MergeFrom(other.Cmyk);
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
          case 8: {
            Alpha = input.ReadUInt32();
            break;
          }
          case 18: {
            global::Model.Design.Appearance.Color.RgbColor subBuilder = new global::Model.Design.Appearance.Color.RgbColor();
            if (valueCase_ == ValueOneofCase.Rgb) {
              subBuilder.MergeFrom(Rgb);
            }
            input.ReadMessage(subBuilder);
            Rgb = subBuilder;
            break;
          }
          case 26: {
            global::Model.Design.Appearance.Color.CmykColor subBuilder = new global::Model.Design.Appearance.Color.CmykColor();
            if (valueCase_ == ValueOneofCase.Cmyk) {
              subBuilder.MergeFrom(Cmyk);
            }
            input.ReadMessage(subBuilder);
            Cmyk = subBuilder;
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
          case 8: {
            Alpha = input.ReadUInt32();
            break;
          }
          case 18: {
            global::Model.Design.Appearance.Color.RgbColor subBuilder = new global::Model.Design.Appearance.Color.RgbColor();
            if (valueCase_ == ValueOneofCase.Rgb) {
              subBuilder.MergeFrom(Rgb);
            }
            input.ReadMessage(subBuilder);
            Rgb = subBuilder;
            break;
          }
          case 26: {
            global::Model.Design.Appearance.Color.CmykColor subBuilder = new global::Model.Design.Appearance.Color.CmykColor();
            if (valueCase_ == ValueOneofCase.Cmyk) {
              subBuilder.MergeFrom(Cmyk);
            }
            input.ReadMessage(subBuilder);
            Cmyk = subBuilder;
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
