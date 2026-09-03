using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchResult : IMessage<MatchResult>, IMessage, IEquatable<MatchResult>, IDeepCloneable<MatchResult>
	{
		private static readonly MessageParser<MatchResult> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CodeFieldNumber = 1;

		private uint code_;

		public const int GaHostFieldNumber = 2;

		private string gaHost_;

		public const int GaPortFieldNumber = 3;

		private uint gaPort_;

		public const int RoomIdFieldNumber = 4;

		private string roomId_;

		public const int RoomTokenFieldNumber = 5;

		private string roomToken_;

		public const int AnotherUserIdFieldNumber = 6;

		private ulong anotherUserId_;

		public const int MapIdFieldNumber = 7;

		private static readonly FieldCodec<string> _repeated_mapId_codec;

		private readonly RepeatedField<string> mapId_;

		public const int IsMasterFieldNumber = 8;

		private bool isMaster_;

		public const int IntegralFactorFieldNumber = 9;

		private int integralFactor_;

		public const int PlayerDataFieldNumber = 10;

		private PlayerInfo playerData_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchResult> Parser => null;

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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GaHost
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
		public uint GaPort
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
		public ulong AnotherUserId
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
		public RepeatedField<string> MapId => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMaster
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
		public int IntegralFactor
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
		public MatchResult()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult(MatchResult other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Clone()
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
		public bool Equals(MatchResult other)
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
		public void MergeFrom(MatchResult other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
