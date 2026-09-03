using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityPirateTreasureExchangeData : IProtocol
	{
		public ushort m_nId;

		public uint m_nCount;

		public uint m_nLastCount;

		public ushort m_nRefresh;

		public string strTargets;

		public string strNeedItems;

		public ushort nStyle;

		public ushort m_nPosition;

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
