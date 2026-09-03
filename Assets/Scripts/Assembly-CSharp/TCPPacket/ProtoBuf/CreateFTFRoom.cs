using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CreateFTFRoom : IMessage<CreateFTFRoom>, IMessage, IEquatable<CreateFTFRoom>, IDeepCloneable<CreateFTFRoom>
	{
		private static readonly MessageParser<CreateFTFRoom> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ProtocolVersionFieldNumber = 1;

		private uint protocolVersion_;

		public const int URawIdFieldNumber = 2;

		private ulong uRawId_;

		public const int PlayerDataFieldNumber = 3;

		private PlayerInfo playerData_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CreateFTFRoom> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ProtocolVersion
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong URawId
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerInfo PlayerData
		{
			get
			{
				return null;
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
		public CreateFTFRoom()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateFTFRoom(CreateFTFRoom other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateFTFRoom Clone()
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
		public bool Equals(CreateFTFRoom other)
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
		public void MergeFrom(CreateFTFRoom other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
