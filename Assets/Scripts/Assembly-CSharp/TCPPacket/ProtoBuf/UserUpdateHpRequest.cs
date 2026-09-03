using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	public sealed class UserUpdateHpRequest : IMessage<UserUpdateHpRequest>, IMessage, IEquatable<UserUpdateHpRequest>, IDeepCloneable<UserUpdateHpRequest>
	{
		private static readonly MessageParser<UserUpdateHpRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CurrHpFieldNumber = 1;

		private uint currHp_;

		public const int MaxHpFieldNumber = 2;

		private uint maxHp_;

		public const int ChangeHpFieldNumber = 3;

		private int changeHp_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UserUpdateHpRequest> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrHp
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
		public uint MaxHp
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
		public int ChangeHp
		{
			get
			{
				return 0;
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
		public UserUpdateHpRequest()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UserUpdateHpRequest(UserUpdateHpRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UserUpdateHpRequest Clone()
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
		public bool Equals(UserUpdateHpRequest other)
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
		public void MergeFrom(UserUpdateHpRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
