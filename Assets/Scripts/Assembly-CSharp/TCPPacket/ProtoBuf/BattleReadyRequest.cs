using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	public sealed class BattleReadyRequest : IMessage<BattleReadyRequest>, IMessage, IEquatable<BattleReadyRequest>, IDeepCloneable<BattleReadyRequest>
	{
		private static readonly MessageParser<BattleReadyRequest> _parser;

		private UnknownFieldSet _unknownFields;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleReadyRequest> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleReadyRequest()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleReadyRequest(BattleReadyRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleReadyRequest Clone()
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
		public bool Equals(BattleReadyRequest other)
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
		public void MergeFrom(BattleReadyRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
