using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityHelpGiftBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public Dictionary<uint, STActivityHelpGiftBoxGroupProtoData> m_dicGiftBoxGroup;

		public STCommonQuickBuyData m_stQuickBuy;

		public STActivityHelpGiftBoxTask m_stTask;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
