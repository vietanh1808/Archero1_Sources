using System.IO;

namespace GameProtocol
{
	public sealed class CRespPlayTowerInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ushort m_nIndex;

		public ushort m_nMode;

		public ushort m_nMaxMode;

		public uint m_nLayer;

		public ushort m_nBattleCnt;

		public ushort m_nBuyCnt;

		public ushort m_nTotalBattleCnt;

		public ulong m_nRewardBits;

		public uint[] vecFirstDone;

		public string[] vecStrBoxRewardItems;

		public string m_strBattleDrop;

		public string strDailyBattleCnt;

		public string strFirstPassDifficulty;

		public bool m_bHasModeUp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
