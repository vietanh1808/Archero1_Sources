using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	public sealed class EnterRoomRequest : IMessage<EnterRoomRequest>, IMessage, IEquatable<EnterRoomRequest>, IDeepCloneable<EnterRoomRequest>
	{
		private static readonly MessageParser<EnterRoomRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int RoomTokenFieldNumber = 1;

		private string roomToken_;

		public const int IsRoomMakeFieldNumber = 2;

		private int isRoomMake_;

		public const int BattleTypeFieldNumber = 3;

		private int battleType_;

		public const int UserIdFieldNumber = 4;

		private ulong userId_;

		public const int TarUserIdFieldNumber = 5;

		private ulong tarUserId_;

		public const int RoomIdFieldNumber = 6;

		private string roomId_;

		public const int MaxHpFieldNumber = 7;

		private int maxHp_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRoomRequest> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RoomToken
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
		public int IsRoomMake
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong UserId
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
		public ulong TarUserId
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
		public string RoomId
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
		public int MaxHp
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
		public EnterRoomRequest()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRoomRequest(EnterRoomRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRoomRequest Clone()
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
		public bool Equals(EnterRoomRequest other)
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
		public void MergeFrom(EnterRoomRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
