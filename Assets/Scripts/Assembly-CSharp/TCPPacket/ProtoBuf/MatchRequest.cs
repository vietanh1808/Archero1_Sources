using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchRequest : IMessage<MatchRequest>, IMessage, IEquatable<MatchRequest>, IDeepCloneable<MatchRequest>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			public enum BattleType
			{
				[OriginalName("NONE")]
				None = 0,
				[OriginalName("FACE_TO_FACE")]
				FaceToFace = 1,
				[OriginalName("GEM_10")]
				Gem10 = 2,
				[OriginalName("GEM_40")]
				Gem40 = 3,
				[OriginalName("GEM_100")]
				Gem100 = 4
			}
		}

		private static readonly MessageParser<MatchRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ProtocolVersionFieldNumber = 1;

		private uint protocolVersion_;

		public const int URawIdFieldNumber = 2;

		private ulong uRawId_;

		public const int BattleTypeFieldNumber = 3;

		private Types.BattleType battleType_;

		public const int PlayerHPFieldNumber = 4;

		private uint playerHP_;

		public const int PlayerAttackFieldNumber = 5;

		private uint playerAttack_;

		public const int PowerValueFieldNumber = 6;

		private uint powerValue_;

		public const int PlayerDataFieldNumber = 7;

		private PlayerInfo playerData_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchRequest> Parser => null;

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
		public Types.BattleType BattleType
		{
			get
			{
				return Types.BattleType.None;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlayerHP
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
		public uint PlayerAttack
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
		public uint PowerValue
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
		public MatchRequest()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRequest(MatchRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRequest Clone()
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
		public bool Equals(MatchRequest other)
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
		public void MergeFrom(MatchRequest other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
