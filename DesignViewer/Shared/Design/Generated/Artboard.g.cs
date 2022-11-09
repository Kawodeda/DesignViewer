// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: artboard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aurigma.Design {

  /// <summary>Holder for reflection information generated from artboard.proto</summary>
  public static partial class ArtboardReflection {

    #region Descriptor
    /// <summary>File descriptor for artboard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArtboardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5hcnRib2FyZC5wcm90bxIGZGVzaWduGhZhcHBlYXJhbmNlL2JydXNoLnBy",
            "b3RvGhttYXRoL2FmZmluZV8yZF9tYXRyaXgucHJvdG8aD21hdGgvc2l6ZS5w",
            "cm90bxoTdHJpbV9zZXR0aW5ncy5wcm90byLAAQoIQXJ0Ym9hcmQSDAoEbmFt",
            "ZRgBIAEoCRIsCgpiYWNrZ3JvdW5kGAIgASgLMhguZGVzaWduLmFwcGVhcmFu",
            "Y2UuQnJ1c2gSKgoFYmFzaXMYAyABKAsyGy5kZXNpZ24ubWF0aC5BZmZpbmUy",
            "RE1hdHJpeBIfCgRzaXplGAQgASgLMhEuZGVzaWduLm1hdGguU2l6ZRIrCg10",
            "cmltX3NldHRpbmdzGAUgASgLMhQuZGVzaWduLlRyaW1TZXR0aW5nc0IRqgIO",
            "QXVyaWdtYS5EZXNpZ25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Aurigma.Design.Appearance.BrushReflection.Descriptor, global::Aurigma.Design.Math.Affine2DMatrixReflection.Descriptor, global::Aurigma.Design.Math.SizeReflection.Descriptor, global::Aurigma.Design.TrimSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aurigma.Design.Artboard), global::Aurigma.Design.Artboard.Parser, new[]{ "Name", "Background", "Basis", "Size", "TrimSettings" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Artboard : pb::IMessage<Artboard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Artboard> _parser = new pb::MessageParser<Artboard>(() => new Artboard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Artboard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aurigma.Design.ArtboardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artboard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artboard(Artboard other) : this() {
      name_ = other.name_;
      background_ = other.background_ != null ? other.background_.Clone() : null;
      basis_ = other.basis_ != null ? other.basis_.Clone() : null;
      size_ = other.size_ != null ? other.size_.Clone() : null;
      trimSettings_ = other.trimSettings_ != null ? other.trimSettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artboard Clone() {
      return new Artboard(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "background" field.</summary>
    public const int BackgroundFieldNumber = 2;
    private global::Aurigma.Design.Appearance.Brush background_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.Appearance.Brush Background {
      get { return background_; }
      set {
        background_ = value;
      }
    }

    /// <summary>Field number for the "basis" field.</summary>
    public const int BasisFieldNumber = 3;
    private global::Aurigma.Design.Math.Affine2DMatrix basis_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.Math.Affine2DMatrix Basis {
      get { return basis_; }
      set {
        basis_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 4;
    private global::Aurigma.Design.Math.Size size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.Math.Size Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "trim_settings" field.</summary>
    public const int TrimSettingsFieldNumber = 5;
    private global::Aurigma.Design.TrimSettings trimSettings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aurigma.Design.TrimSettings TrimSettings {
      get { return trimSettings_; }
      set {
        trimSettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Artboard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Artboard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Background, other.Background)) return false;
      if (!object.Equals(Basis, other.Basis)) return false;
      if (!object.Equals(Size, other.Size)) return false;
      if (!object.Equals(TrimSettings, other.TrimSettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (background_ != null) hash ^= Background.GetHashCode();
      if (basis_ != null) hash ^= Basis.GetHashCode();
      if (size_ != null) hash ^= Size.GetHashCode();
      if (trimSettings_ != null) hash ^= TrimSettings.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (background_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Background);
      }
      if (basis_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Basis);
      }
      if (size_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Size);
      }
      if (trimSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(TrimSettings);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (background_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Background);
      }
      if (basis_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Basis);
      }
      if (size_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Size);
      }
      if (trimSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(TrimSettings);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (background_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Background);
      }
      if (basis_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Basis);
      }
      if (size_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Size);
      }
      if (trimSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrimSettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Artboard other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.background_ != null) {
        if (background_ == null) {
          Background = new global::Aurigma.Design.Appearance.Brush();
        }
        Background.MergeFrom(other.Background);
      }
      if (other.basis_ != null) {
        if (basis_ == null) {
          Basis = new global::Aurigma.Design.Math.Affine2DMatrix();
        }
        Basis.MergeFrom(other.Basis);
      }
      if (other.size_ != null) {
        if (size_ == null) {
          Size = new global::Aurigma.Design.Math.Size();
        }
        Size.MergeFrom(other.Size);
      }
      if (other.trimSettings_ != null) {
        if (trimSettings_ == null) {
          TrimSettings = new global::Aurigma.Design.TrimSettings();
        }
        TrimSettings.MergeFrom(other.TrimSettings);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (background_ == null) {
              Background = new global::Aurigma.Design.Appearance.Brush();
            }
            input.ReadMessage(Background);
            break;
          }
          case 26: {
            if (basis_ == null) {
              Basis = new global::Aurigma.Design.Math.Affine2DMatrix();
            }
            input.ReadMessage(Basis);
            break;
          }
          case 34: {
            if (size_ == null) {
              Size = new global::Aurigma.Design.Math.Size();
            }
            input.ReadMessage(Size);
            break;
          }
          case 42: {
            if (trimSettings_ == null) {
              TrimSettings = new global::Aurigma.Design.TrimSettings();
            }
            input.ReadMessage(TrimSettings);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (background_ == null) {
              Background = new global::Aurigma.Design.Appearance.Brush();
            }
            input.ReadMessage(Background);
            break;
          }
          case 26: {
            if (basis_ == null) {
              Basis = new global::Aurigma.Design.Math.Affine2DMatrix();
            }
            input.ReadMessage(Basis);
            break;
          }
          case 34: {
            if (size_ == null) {
              Size = new global::Aurigma.Design.Math.Size();
            }
            input.ReadMessage(Size);
            break;
          }
          case 42: {
            if (trimSettings_ == null) {
              TrimSettings = new global::Aurigma.Design.TrimSettings();
            }
            input.ReadMessage(TrimSettings);
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
