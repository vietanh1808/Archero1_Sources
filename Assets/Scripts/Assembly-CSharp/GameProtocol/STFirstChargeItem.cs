using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STFirstChargeItem : IProtocol
	{
		public ushort m_nId;

		public ushort m_nOpen;

		public ushort m_nPosition;

		public string m_strProductId;

		public ushort m_nDiscount;

		public string m_strRewards;

		public ulong m_nChargeTime;

		public ulong m_nBitRewards;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
