using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerProofreadingAttInfo : IMessage<PlayerProofreadingAttInfo>, IMessage, IEquatable<PlayerProofreadingAttInfo>, IDeepCloneable<PlayerProofreadingAttInfo>
	{
		private static readonly MessageParser<PlayerProofreadingAttInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int PlayerHpFieldNumber = 1;

		private long playerHp_;

		public const int PlayerAttackFieldNumber = 2;

		private long playerAttack_;

		public const int MoveSpeedFieldNumber = 3;

		private long moveSpeed_;

		public const int AttInfoFieldNumber = 4;

		private PVPPlayerAttInfo attInfo_;

		public const int AddAttlistFieldNumber = 5;

		private static readonly FieldCodec<AddAttStringData> _repeated_addAttlist_codec;

		private readonly RepeatedField<AddAttStringData> addAttlist_;

		public const int OutsideAttlistFieldNumber = 6;

		private static readonly FieldCodec<AddAttStringData> _repeated_outsideAttlist_codec;

		private readonly RepeatedField<AddAttStringData> outsideAttlist_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerProofreadingAttInfo> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerHp
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
		public long PlayerAttack
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
		public long MoveSpeed
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
		public PVPPlayerAttInfo AttInfo
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
		public RepeatedField<AddAttStringData> AddAttlist => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddAttStringData> OutsideAttlist => null;

		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerProofreadingAttInfo()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerProofreadingAttInfo(PlayerProofreadingAttInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerProofreadingAttInfo Clone()
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
		public bool Equals(PlayerProofreadingAttInfo other)
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
		public void MergeFrom(PlayerProofreadingAttInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
