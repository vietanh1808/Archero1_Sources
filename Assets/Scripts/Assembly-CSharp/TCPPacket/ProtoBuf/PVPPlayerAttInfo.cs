using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PVPPlayerAttInfo : IMessage<PVPPlayerAttInfo>, IMessage, IEquatable<PVPPlayerAttInfo>, IDeepCloneable<PVPPlayerAttInfo>
	{
		private static readonly MessageParser<PVPPlayerAttInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int HeadIdFieldNumber = 2;

		private int headId_;

		public const int HeadFrameIdFieldNumber = 3;

		private int headFrameId_;

		public const int HeadFrameTimeFieldNumber = 4;

		private long headFrameTime_;

		public const int ScoreFieldNumber = 5;

		private int score_;

		public const int VipLvFieldNumber = 6;

		private int vipLv_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PVPPlayerAttInfo> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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
		public int HeadId
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
		public int HeadFrameId
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
		public long HeadFrameTime
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
		public int Score
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
		public int VipLv
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
		public PVPPlayerAttInfo()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVPPlayerAttInfo(PVPPlayerAttInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVPPlayerAttInfo Clone()
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
		public bool Equals(PVPPlayerAttInfo other)
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
		public void MergeFrom(PVPPlayerAttInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
