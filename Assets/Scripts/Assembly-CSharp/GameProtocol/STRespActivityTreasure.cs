using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityTreasure : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public ushort m_nStepIndex;

		public ushort m_nProgress;

		public ulong m_nRewardBits;

		public ushort m_nBuyCnt;

		public ushort m_nSelectId;

		public string m_strTreasureCnt;

		public uint m_nBPPoint;

		public ulong m_nBPFreeRewardBits;

		public ulong m_nBPNormalRewardBits;

		public ulong m_nBPBigRewardBits;

		public ushort m_nHitId;

		public bool m_bIapBattlePass;

		public bool m_bIapBigBattlePass;

		public string m_strPayCount;

		public ushort m_nTag;

		public ushort[] m_vecHitIds;

		public ushort m_nGuaranteeTimes;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
