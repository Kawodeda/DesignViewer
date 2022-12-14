// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: element.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Model.Design {

  /// <summary>Holder for reflection information generated from element.proto</summary>
  public static partial class ElementReflection {

    #region Descriptor
    /// <summary>File descriptor for element.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ElementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1lbGVtZW50LnByb3RvEgZkZXNpZ24aHWNvbnRlbnQvZWxlbWVudF9jb250",
            "ZW50LnByb3RvGhttYXRoL2FmZmluZV8yZF9tYXRyaXgucHJvdG8aEG1hdGgv",
            "cG9pbnQucHJvdG8ixQEKB0VsZW1lbnQSJAoIcG9zaXRpb24YASABKAsyEi5k",
            "ZXNpZ24ubWF0aC5Qb2ludBIuCgl0cmFuc2Zvcm0YAiABKAsyGy5kZXNpZ24u",
            "bWF0aC5BZmZpbmUyRE1hdHJpeBIzCg9yZWZlcmVuY2VfcG9pbnQYAyABKA4y",
            "Gi5kZXNpZ24uUmVmZXJlbmNlUG9pbnRUeXBlEi8KB2NvbnRlbnQYBCABKAsy",
            "Hi5kZXNpZ24uY29udGVudC5FbGVtZW50Q29udGVudCpGChJSZWZlcmVuY2VQ",
            "b2ludFR5cGUSDwoLVU5TUEVDSUZJRUQQABITCg9UT1BfTEVGVF9DT1JORVIQ",
            "ARIKCgZDRU5URVIQAkIPqgIMTW9kZWwuRGVzaWduYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Model.Design.Content.ElementContentReflection.Descriptor, global::Model.Design.Math.Affine2DMatrixReflection.Descriptor, global::Model.Design.Math.PointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Model.Design.ReferencePointType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Model.Design.Element), global::Model.Design.Element.Parser, new[]{ "Position", "Transform", "ReferencePoint", "Content" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// ReferencePointType defines how we interpret the position property of 
  /// an Element, whether it be its top-left corner, center, etc.
  /// </summary>
  public enum ReferencePointType {
    [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("TOP_LEFT_CORNER")] TopLeftCorner = 1,
    [pbr::OriginalName("CENTER")] Center = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// An Element represents a concrete graphical object such as shape, image,
  /// text, etc., located at a specific surface on a specific layer and transformed
  /// in a specific way. The concrete type of an Element is defined by its content
  /// property.
  /// </summary>
  public sealed partial class Element : pb::IMessage<Element>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Element> _parser = new pb::MessageParser<Element>(() => new Element());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Element> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Model.Design.ElementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Element() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Element(Element other) : this() {
      position_ = other.position_ != null ? other.position_.Clone() : null;
      transform_ = other.transform_ != null ? other.transform_.Clone() : null;
      referencePoint_ = other.referencePoint_;
      content_ = other.content_ != null ? other.content_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Element Clone() {
      return new Element(this);
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 1;
    private global::Model.Design.Math.Point position_;
    /// <summary>
    /// Defines the position of an element relative to the surface
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Math.Point Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 2;
    private global::Model.Design.Math.Affine2DMatrix transform_;
    /// <summary>
    /// Defines the transformation of an element
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Math.Affine2DMatrix Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    /// <summary>Field number for the "reference_point" field.</summary>
    public const int ReferencePointFieldNumber = 3;
    private global::Model.Design.ReferencePointType referencePoint_ = global::Model.Design.ReferencePointType.Unspecified;
    /// <summary>
    /// Defines the location of the reference point of an element
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.ReferencePointType ReferencePoint {
      get { return referencePoint_; }
      set {
        referencePoint_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 4;
    private global::Model.Design.Content.ElementContent content_;
    /// <summary>
    /// Defines the concrete content of an element
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Model.Design.Content.ElementContent Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Element);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Element other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      if (ReferencePoint != other.ReferencePoint) return false;
      if (!object.Equals(Content, other.Content)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (position_ != null) hash ^= Position.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (ReferencePoint != global::Model.Design.ReferencePointType.Unspecified) hash ^= ReferencePoint.GetHashCode();
      if (content_ != null) hash ^= Content.GetHashCode();
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
      if (position_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Position);
      }
      if (transform_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Transform);
      }
      if (ReferencePoint != global::Model.Design.ReferencePointType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ReferencePoint);
      }
      if (content_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Content);
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
      if (position_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Position);
      }
      if (transform_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Transform);
      }
      if (ReferencePoint != global::Model.Design.ReferencePointType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ReferencePoint);
      }
      if (content_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Content);
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
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (ReferencePoint != global::Model.Design.ReferencePointType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReferencePoint);
      }
      if (content_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Element other) {
      if (other == null) {
        return;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Model.Design.Math.Point();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          Transform = new global::Model.Design.Math.Affine2DMatrix();
        }
        Transform.MergeFrom(other.Transform);
      }
      if (other.ReferencePoint != global::Model.Design.ReferencePointType.Unspecified) {
        ReferencePoint = other.ReferencePoint;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          Content = new global::Model.Design.Content.ElementContent();
        }
        Content.MergeFrom(other.Content);
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
            if (position_ == null) {
              Position = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Position);
            break;
          }
          case 18: {
            if (transform_ == null) {
              Transform = new global::Model.Design.Math.Affine2DMatrix();
            }
            input.ReadMessage(Transform);
            break;
          }
          case 24: {
            ReferencePoint = (global::Model.Design.ReferencePointType) input.ReadEnum();
            break;
          }
          case 34: {
            if (content_ == null) {
              Content = new global::Model.Design.Content.ElementContent();
            }
            input.ReadMessage(Content);
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
            if (position_ == null) {
              Position = new global::Model.Design.Math.Point();
            }
            input.ReadMessage(Position);
            break;
          }
          case 18: {
            if (transform_ == null) {
              Transform = new global::Model.Design.Math.Affine2DMatrix();
            }
            input.ReadMessage(Transform);
            break;
          }
          case 24: {
            ReferencePoint = (global::Model.Design.ReferencePointType) input.ReadEnum();
            break;
          }
          case 34: {
            if (content_ == null) {
              Content = new global::Model.Design.Content.ElementContent();
            }
            input.ReadMessage(Content);
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
