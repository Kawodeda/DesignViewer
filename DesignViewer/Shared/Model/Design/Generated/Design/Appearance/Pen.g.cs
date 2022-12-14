// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: appearance/pen.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design.Appearance {

  /// <summary>Holder for reflection information generated from appearance/pen.proto</summary>
  public static partial class PenReflection {

    #region Descriptor
    /// <summary>File descriptor for appearance/pen.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PenReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRhcHBlYXJhbmNlL3Blbi5wcm90bxIRZGVzaWduLmFwcGVhcmFuY2UaFmFw",
            "cGVhcmFuY2UvYnJ1c2gucHJvdG8aHGFwcGVhcmFuY2UvY29sb3IvY29sb3Iu",
            "cHJvdG8ilQIKA1BlbhINCgV3aWR0aBgBIAEoAhIsCghsaW5lX2NhcBgCIAEo",
            "DjIaLmRlc2lnbi5hcHBlYXJhbmNlLkxpbmVDYXASLgoJbGluZV9qb2luGAMg",
            "ASgOMhsuZGVzaWduLmFwcGVhcmFuY2UuTGluZUpvaW4SEwoLbWl0ZXJfbGlt",
            "aXQYBCABKAISEwoLZGFzaF9vZmZzZXQYBSABKAISDgoGZGFzaGVzGAYgAygC",
            "Ei8KBWNvbG9yGAcgASgLMh4uZGVzaWduLmFwcGVhcmFuY2UuY29sb3IuQ29s",
            "b3JIABIoCgRmaWxsGAggASgLMhguZGVzaWduLmFwcGVhcmFuY2UuQnJ1c2hI",
            "AEIMCgphcHBlYXJhbmNlKmEKB0xpbmVDYXASGAoUTElORV9DQVBfVU5TUEVD",
            "SUZJRUQQABITCg9MSU5FX0NBUF9CVVRUT04QARISCg5MSU5FX0NBUF9ST1VO",
            "RBACEhMKD0xJTkVfQ0FQX1NRVUFSRRADKmQKCExpbmVKb2luEhkKFUxJTkVf",
            "Sk9JTl9VTlNQRUNJRklFRBAAEhMKD0xJTkVfSk9JTl9CRVZFTBABEhMKD0xJ",
            "TkVfSk9JTl9NSVRFUhACEhMKD0xJTkVfSk9JTl9ST1VORBADQhqqAhdNb2Rl",
            "bC5EZXNpZ24uQXBwZWFyYW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Appearance.BrushReflection.Descriptor, global::Model.Design.Appearance.Color.ColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Model.Design.Appearance.LineCap), typeof(global::Model.Design.Appearance.LineJoin), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Appearance.Pen), global::Model.Design.Appearance.Pen.Parser, new[]{ "Width", "LineCap", "LineJoin", "MiterLimit", "DashOffset", "Dashes", "Color", "Fill" }, new[]{ "Appearance" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum LineCap {
    [pbr::OriginalName("LINE_CAP_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("LINE_CAP_BUTTON")] Button = 1,
    [pbr::OriginalName("LINE_CAP_ROUND")] Round = 2,
    [pbr::OriginalName("LINE_CAP_SQUARE")] Square = 3,
  }

  public enum LineJoin {
    [pbr::OriginalName("LINE_JOIN_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("LINE_JOIN_BEVEL")] Bevel = 1,
    [pbr::OriginalName("LINE_JOIN_MITER")] Miter = 2,
    [pbr::OriginalName("LINE_JOIN_ROUND")] Round = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// A Pen describes the appearance of vector's stroke.
  /// </summary>
  public sealed partial class Pen : pb::IMessage<Pen>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Pen> _parser = new pb::MessageParser<Pen>(() => new Pen());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Pen> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.Appearance.PenReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Pen() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Pen(Pen other) : this() {
      width_ = other.width_;
      lineCap_ = other.lineCap_;
      lineJoin_ = other.lineJoin_;
      miterLimit_ = other.miterLimit_;
      dashOffset_ = other.dashOffset_;
      dashes_ = other.dashes_.Clone();
      switch (other.AppearanceCase) {
        case AppearanceOneofCase.Color:
          Color = other.Color.Clone();
          break;
        case AppearanceOneofCase.Fill:
          Fill = other.Fill.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Pen Clone() {
      return new Pen(this);
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 1;
    private float width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "line_cap" field.</summary>
    public const int LineCapFieldNumber = 2;
    private global::Model.Design.Appearance.LineCap lineCap_ = global::Model.Design.Appearance.LineCap.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.LineCap LineCap {
      get { return lineCap_; }
      set {
        lineCap_ = value;
      }
    }

    /// <summary>Field number for the "line_join" field.</summary>
    public const int LineJoinFieldNumber = 3;
    private global::Model.Design.Appearance.LineJoin lineJoin_ = global::Model.Design.Appearance.LineJoin.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.LineJoin LineJoin {
      get { return lineJoin_; }
      set {
        lineJoin_ = value;
      }
    }

    /// <summary>Field number for the "miter_limit" field.</summary>
    public const int MiterLimitFieldNumber = 4;
    private float miterLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MiterLimit {
      get { return miterLimit_; }
      set {
        miterLimit_ = value;
      }
    }

    /// <summary>Field number for the "dash_offset" field.</summary>
    public const int DashOffsetFieldNumber = 5;
    private float dashOffset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float DashOffset {
      get { return dashOffset_; }
      set {
        dashOffset_ = value;
      }
    }

    /// <summary>Field number for the "dashes" field.</summary>
    public const int DashesFieldNumber = 6;
    private static readonly pb::FieldCodec<float> _repeated_dashes_codec
        = pb::FieldCodec.ForFloat(50);
    private readonly pbc::RepeatedField<float> dashes_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<float> Dashes {
      get { return dashes_; }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Color.Color Color {
      get { return appearanceCase_ == AppearanceOneofCase.Color ? (global::Model.Design.Appearance.Color.Color) appearance_ : null; }
      set {
        appearance_ = value;
        appearanceCase_ = value == null ? AppearanceOneofCase.None : AppearanceOneofCase.Color;
      }
    }

    /// <summary>Field number for the "fill" field.</summary>
    public const int FillFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Appearance.Brush Fill {
      get { return appearanceCase_ == AppearanceOneofCase.Fill ? (global::Model.Design.Appearance.Brush) appearance_ : null; }
      set {
        appearance_ = value;
        appearanceCase_ = value == null ? AppearanceOneofCase.None : AppearanceOneofCase.Fill;
      }
    }

    private object appearance_;
    /// <summary>Enum of possible cases for the "appearance" oneof.</summary>
    public enum AppearanceOneofCase {
      None = 0,
      Color = 7,
      Fill = 8,
    }
    private AppearanceOneofCase appearanceCase_ = AppearanceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AppearanceOneofCase AppearanceCase {
      get { return appearanceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAppearance() {
      appearanceCase_ = AppearanceOneofCase.None;
      appearance_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Pen);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Pen other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Width, other.Width)) return false;
      if (LineCap != other.LineCap) return false;
      if (LineJoin != other.LineJoin) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MiterLimit, other.MiterLimit)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DashOffset, other.DashOffset)) return false;
      if(!dashes_.Equals(other.dashes_)) return false;
      if (!object.Equals(Color, other.Color)) return false;
      if (!object.Equals(Fill, other.Fill)) return false;
      if (AppearanceCase != other.AppearanceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Width != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Width);
      if (LineCap != global::Model.Design.Appearance.LineCap.Unspecified) hash ^= LineCap.GetHashCode();
      if (LineJoin != global::Model.Design.Appearance.LineJoin.Unspecified) hash ^= LineJoin.GetHashCode();
      if (MiterLimit != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MiterLimit);
      if (DashOffset != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DashOffset);
      hash ^= dashes_.GetHashCode();
      if (appearanceCase_ == AppearanceOneofCase.Color) hash ^= Color.GetHashCode();
      if (appearanceCase_ == AppearanceOneofCase.Fill) hash ^= Fill.GetHashCode();
      hash ^= (int) appearanceCase_;
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
      if (Width != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Width);
      }
      if (LineCap != global::Model.Design.Appearance.LineCap.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LineCap);
      }
      if (LineJoin != global::Model.Design.Appearance.LineJoin.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LineJoin);
      }
      if (MiterLimit != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MiterLimit);
      }
      if (DashOffset != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(DashOffset);
      }
      dashes_.WriteTo(output, _repeated_dashes_codec);
      if (appearanceCase_ == AppearanceOneofCase.Color) {
        output.WriteRawTag(58);
        output.WriteMessage(Color);
      }
      if (appearanceCase_ == AppearanceOneofCase.Fill) {
        output.WriteRawTag(66);
        output.WriteMessage(Fill);
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
      if (Width != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Width);
      }
      if (LineCap != global::Model.Design.Appearance.LineCap.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LineCap);
      }
      if (LineJoin != global::Model.Design.Appearance.LineJoin.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LineJoin);
      }
      if (MiterLimit != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MiterLimit);
      }
      if (DashOffset != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(DashOffset);
      }
      dashes_.WriteTo(ref output, _repeated_dashes_codec);
      if (appearanceCase_ == AppearanceOneofCase.Color) {
        output.WriteRawTag(58);
        output.WriteMessage(Color);
      }
      if (appearanceCase_ == AppearanceOneofCase.Fill) {
        output.WriteRawTag(66);
        output.WriteMessage(Fill);
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
      if (Width != 0F) {
        size += 1 + 4;
      }
      if (LineCap != global::Model.Design.Appearance.LineCap.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LineCap);
      }
      if (LineJoin != global::Model.Design.Appearance.LineJoin.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LineJoin);
      }
      if (MiterLimit != 0F) {
        size += 1 + 4;
      }
      if (DashOffset != 0F) {
        size += 1 + 4;
      }
      size += dashes_.CalculateSize(_repeated_dashes_codec);
      if (appearanceCase_ == AppearanceOneofCase.Color) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Color);
      }
      if (appearanceCase_ == AppearanceOneofCase.Fill) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Fill);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Pen other) {
      if (other == null) {
        return;
      }
      if (other.Width != 0F) {
        Width = other.Width;
      }
      if (other.LineCap != global::Model.Design.Appearance.LineCap.Unspecified) {
        LineCap = other.LineCap;
      }
      if (other.LineJoin != global::Model.Design.Appearance.LineJoin.Unspecified) {
        LineJoin = other.LineJoin;
      }
      if (other.MiterLimit != 0F) {
        MiterLimit = other.MiterLimit;
      }
      if (other.DashOffset != 0F) {
        DashOffset = other.DashOffset;
      }
      dashes_.Add(other.dashes_);
      switch (other.AppearanceCase) {
        case AppearanceOneofCase.Color:
          if (Color == null) {
            Color = new global::Model.Design.Appearance.Color.Color();
          }
          Color.MergeFrom(other.Color);
          break;
        case AppearanceOneofCase.Fill:
          if (Fill == null) {
            Fill = new global::Model.Design.Appearance.Brush();
          }
          Fill.MergeFrom(other.Fill);
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
          case 13: {
            Width = input.ReadFloat();
            break;
          }
          case 16: {
            LineCap = (global::Model.Design.Appearance.LineCap) input.ReadEnum();
            break;
          }
          case 24: {
            LineJoin = (global::Model.Design.Appearance.LineJoin) input.ReadEnum();
            break;
          }
          case 37: {
            MiterLimit = input.ReadFloat();
            break;
          }
          case 45: {
            DashOffset = input.ReadFloat();
            break;
          }
          case 50:
          case 53: {
            dashes_.AddEntriesFrom(input, _repeated_dashes_codec);
            break;
          }
          case 58: {
            global::Model.Design.Appearance.Color.Color subBuilder = new global::Model.Design.Appearance.Color.Color();
            if (appearanceCase_ == AppearanceOneofCase.Color) {
              subBuilder.MergeFrom(Color);
            }
            input.ReadMessage(subBuilder);
            Color = subBuilder;
            break;
          }
          case 66: {
            global::Model.Design.Appearance.Brush subBuilder = new global::Model.Design.Appearance.Brush();
            if (appearanceCase_ == AppearanceOneofCase.Fill) {
              subBuilder.MergeFrom(Fill);
            }
            input.ReadMessage(subBuilder);
            Fill = subBuilder;
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
          case 13: {
            Width = input.ReadFloat();
            break;
          }
          case 16: {
            LineCap = (global::Model.Design.Appearance.LineCap) input.ReadEnum();
            break;
          }
          case 24: {
            LineJoin = (global::Model.Design.Appearance.LineJoin) input.ReadEnum();
            break;
          }
          case 37: {
            MiterLimit = input.ReadFloat();
            break;
          }
          case 45: {
            DashOffset = input.ReadFloat();
            break;
          }
          case 50:
          case 53: {
            dashes_.AddEntriesFrom(ref input, _repeated_dashes_codec);
            break;
          }
          case 58: {
            global::Model.Design.Appearance.Color.Color subBuilder = new global::Model.Design.Appearance.Color.Color();
            if (appearanceCase_ == AppearanceOneofCase.Color) {
              subBuilder.MergeFrom(Color);
            }
            input.ReadMessage(subBuilder);
            Color = subBuilder;
            break;
          }
          case 66: {
            global::Model.Design.Appearance.Brush subBuilder = new global::Model.Design.Appearance.Brush();
            if (appearanceCase_ == AppearanceOneofCase.Fill) {
              subBuilder.MergeFrom(Fill);
            }
            input.ReadMessage(subBuilder);
            Fill = subBuilder;
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
