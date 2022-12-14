// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: appearance/color/cmyk_color.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Appearance.Color {

  /// <summary>Holder for reflection information generated from appearance/color/cmyk_color.proto</summary>
  public static partial class CmykColorReflection {

    #region Descriptor
    /// <summary>File descriptor for appearance/color/cmyk_color.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CmykColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFhcHBlYXJhbmNlL2NvbG9yL2NteWtfY29sb3IucHJvdG8SF2Rlc2lnbi5h",
            "cHBlYXJhbmNlLmNvbG9yIjcKCUNteWtDb2xvchIJCgFjGAEgASgNEgkKAW0Y",
            "AiABKA0SCQoBeRgDIAEoDRIJCgFrGAQgASgNQiCqAh1Nb2RlbC5EZXNpZ24u",
            "QXBwZWFyYW5jZS5Db2xvcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Appearance.Color.CmykColor), global::Model.Design.Appearance.Color.CmykColor.Parser, new[]{ "C", "M", "Y", "K" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A CmykColor represents a color in CMYK color space, i.e. it is encoded as
  /// cyan, magenta, yellow and key components.
  /// </summary>
  public sealed partial class CmykColor : pb::IMessage<CmykColor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CmykColor> _parser = new pb::MessageParser<CmykColor>(() => new CmykColor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CmykColor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Appearance.Color.CmykColorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CmykColor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CmykColor(CmykColor other) : this() {
      c_ = other.c_;
      m_ = other.m_;
      y_ = other.y_;
      k_ = other.k_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CmykColor Clone() {
      return new CmykColor(this);
    }

    /// <summary>Field number for the "c" field.</summary>
    public const int CFieldNumber = 1;
    private uint c_;
    /// <summary>
    /// Cyan component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint C {
      get { return c_; }
      set {
        c_ = value;
      }
    }

    /// <summary>Field number for the "m" field.</summary>
    public const int MFieldNumber = 2;
    private uint m_;
    /// <summary>
    /// Magenta component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint M {
      get { return m_; }
      set {
        m_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 3;
    private uint y_;
    /// <summary>
    /// Yellow component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "k" field.</summary>
    public const int KFieldNumber = 4;
    private uint k_;
    /// <summary>
    /// Key (or Black) component
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint K {
      get { return k_; }
      set {
        k_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CmykColor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CmykColor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (C != other.C) return false;
      if (M != other.M) return false;
      if (Y != other.Y) return false;
      if (K != other.K) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (C != 0) hash ^= C.GetHashCode();
      if (M != 0) hash ^= M.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (K != 0) hash ^= K.GetHashCode();
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
      if (C != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(C);
      }
      if (M != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(M);
      }
      if (Y != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Y);
      }
      if (K != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(K);
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
      if (C != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(C);
      }
      if (M != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(M);
      }
      if (Y != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Y);
      }
      if (K != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(K);
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
      if (C != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(C);
      }
      if (M != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(M);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Y);
      }
      if (K != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(K);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CmykColor other) {
      if (other == null) {
        return;
      }
      if (other.C != 0) {
        C = other.C;
      }
      if (other.M != 0) {
        M = other.M;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.K != 0) {
        K = other.K;
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
            C = input.ReadUInt32();
            break;
          }
          case 16: {
            M = input.ReadUInt32();
            break;
          }
          case 24: {
            Y = input.ReadUInt32();
            break;
          }
          case 32: {
            K = input.ReadUInt32();
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
            C = input.ReadUInt32();
            break;
          }
          case 16: {
            M = input.ReadUInt32();
            break;
          }
          case 24: {
            Y = input.ReadUInt32();
            break;
          }
          case 32: {
            K = input.ReadUInt32();
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
