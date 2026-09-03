using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespTreasureShop : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nOpenStatus;

		public uint m_nFloorPer;

		public uint[] m_vecGridEvents;

		public uint[][] m_vecProducts;

		public uint[][] m_vecSpend;

		public uint[][] m_vecDiscountSpend;

		public STTreasureProduct[] m_vecPreviewProducts;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
