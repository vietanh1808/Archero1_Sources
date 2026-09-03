using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GoodItem : IMessage<GoodItem>, IMessage, IEquatable<GoodItem>, IDeepCloneable<GoodItem>
	{
		private static readonly MessageParser<GoodItem> _parser;

		private UnknownFieldSet _unknownFields;

		public const int GoodTypeFieldNumber = 1;

		private string goodType_;

		public const int ValueFieldNumber = 2;

		private long value_;

		public const int PercentFieldNumber = 3;

		private bool percent_;

		public const int IsAllFieldNumber = 4;

		private bool isAll_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GoodItem> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GoodType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Value
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Percent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAll
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodItem()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodItem(GoodItem other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodItem Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GoodItem other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GoodItem other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
