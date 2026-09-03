using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CBoxGemActivityInfo : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nType;

		public string m_strPreview;

		public string m_nGiftIcon;

		public ushort m_nNum;

		public ushort m_nPrice;

		public int m_nBoxId;

		public ushort m_nAdPrice;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public string ToDebugString()
		{
			return null;
		}

		public string[] GetPreviews()
		{
			return null;
		}
	}
}
