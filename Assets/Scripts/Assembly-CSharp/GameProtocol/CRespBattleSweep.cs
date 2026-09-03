using System.IO;

namespace GameProtocol
{
	public sealed class CRespBattleSweep : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strChapFinishs;

		public string m_strHeroChapFinishs;

		public uint m_nSweepCnt;

		public ushort m_nLifeValue;

		public uint[] vecShopIds;

		public string m_strHatchSteps;

		public string m_strMonKills;

		public uint m_nSweepCntAdd;

		public uint[] m_vecTreasureShopGridEvents;

		public uint[][] m_vecTreasureShopProducts;

		public uint[][] m_vecTreasureShopSpend;

		public uint[][] m_vecTreasureShopDiscountSpend;

		public STTreasureProduct[] m_vecTreasureShopPreviewProducts;

		public string m_strHellChapFinishs;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
