// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: appearance/color/rgb_color.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Appearance.Color {

  /// <summary>Holder for reflection information generated from appearance/color/rgb_color.proto</summary>
  public static partial class RgbColorReflection {

    #region Descriptor
    /// <summary>File descriptor for appearance/color/rgb_color.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RgbColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBhcHBlYXJhbmNlL2NvbG9yL3JnYl9jb2xvci5wcm90bxIXZGVzaWduLmFw",
            "cGVhcmFuY2UuY29sb3IiKwoIUmdiQ29sb3ISCQoBchgBIAEoDRIJCgFnGAIg",
            "ASgNEgkKAWIYAyABKA1CIKoCHU1vZGVsLkRlc2lnbi5BcHBlYXJhbmNlLkNv",
            "bG9yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Appearance.Color.RgbColor), global::Model.Design.Appearance.Color.RgbColor.Parser, new[]{ "R", "G", "B" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An RgbColor represents a color in RGB color space, i.e. it is encoded as
  /// red, green and blue components.
  /// </summary>
  public sealed partial class RgbColor : pb::IMessage<RgbColor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RgbColor> _parser = new pb::MessageParser<RgbColor>(() => new RgbColor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RgbColor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Appearance.Color.RgbColorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RgbColor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RgbColor(RgbColor other) : this() {
      r_ = other.r_;
      g_ = other.g_;
      b_ = other.b_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RgbColor Clone() {
      return new RgbColor(this);
    }

    /// <summary>Field number for the "r" field.</summary>
    public const int RFieldNumber = 1;
    private uint r_;
    /// <summary>
    /// Red component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint R {
      get { return r_; }
      set {
        r_ = value;
      }
    }

    /// <summary>Field number for the "g" field.</summary>
    public const int GFieldNumber = 2;
    private uint g_;
    /// <summary>
    /// Green component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint G {
      get { return g_; }
      set {
        g_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 3;
    private uint b_;
    /// <summary>
    /// Blue component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint B {
      get { return b_; }
      set {
        b_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RgbColor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RgbColor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (R != other.R) return false;
      if (G != other.G) return false;
      if (B != other.B) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (R != 0) hash ^= R.GetHashCode();
      if (G != 0) hash ^= G.GetHashCode();
      if (B != 0) hash ^= B.GetHashCode();
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
      if (R != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(R);
      }
      if (G != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(G);
      }
      if (B != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(B);
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
      if (R != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(R);
      }
      if (G != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(G);
      }
      if (B != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(B);
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
      if (R != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(R);
      }
      if (G != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(G);
      }
      if (B != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(B);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RgbColor other) {
      if (other == null) {
        return;
      }
      if (other.R != 0) {
        R = other.R;
      }
      if (other.G != 0) {
        G = other.G;
      }
      if (other.B != 0) {
        B = other.B;
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
            R = input.ReadUInt32();
            break;
          }
          case 16: {
            G = input.ReadUInt32();
            break;
          }
          case 24: {
            B = input.ReadUInt32();
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
            R = input.ReadUInt32();
            break;
          }
          case 16: {
            G = input.ReadUInt32();
            break;
          }
          case 24: {
            B = input.ReadUInt32();
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
