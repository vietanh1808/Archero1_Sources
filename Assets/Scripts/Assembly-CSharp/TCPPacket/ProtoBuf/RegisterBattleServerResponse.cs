using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	public sealed class RegisterBattleServerResponse : IMessage<RegisterBattleServerResponse>, IMessage, IEquatable<RegisterBattleServerResponse>, IDeepCloneable<RegisterBattleServerResponse>
	{
		private static readonly MessageParser<RegisterBattleServerResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CodeFieldNumber = 1;

		private uint code_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RegisterBattleServerResponse> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Code
		{
			get
			{
				return 0u;
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
		public RegisterBattleServerResponse()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegisterBattleServerResponse(RegisterBattleServerResponse other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegisterBattleServerResponse Clone()
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
		public bool Equals(RegisterBattleServerResponse other)
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
		public void MergeFrom(RegisterBattleServerResponse other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
