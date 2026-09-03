using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespActivityShip : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ushort m_nShipType;

		public CActivityShipNormalItem[] m_vecNormalItems;

		public CActivityShipPayItem[] m_vecPayItems;

		public ulong m_nEndTime;

		public uint m_nTag;

		public ushort m_nFreeCnt;

		public ushort m_MaxFreeCnt;

		public ushort m_nBuyCnt;

		public ushort m_nMaxBuyCnt;

		public ushort m_nCostDiamonds;

		public ushort m_nNormalTag;

		public ulong m_nNormalStartTime;

		public ulong m_nNormalEndTime;

		public ulong m_nPayStartTime;

		public ulong m_nPayEndTime;

		public CActivityShipRelicsGift m_stRelicsGift;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
