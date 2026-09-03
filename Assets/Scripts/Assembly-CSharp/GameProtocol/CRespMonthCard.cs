using System.IO;

namespace GameProtocol
{
	public sealed class CRespMonthCard : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public bool m_nIsCanReceive;

		public ulong m_nExpiresTimestamp;

		public ushort m_nRenewCount;

		public ushort m_nAddSweepCnt;

		public ulong m_nBattlePassCount;

		public ushort m_nTotalRenewCount;

		public ushort m_nReceiveCount;

		public ulong m_nSeniorExpiresTimestamp;

		public bool m_nSeniorIsCanReceive;

		public ushort m_nSeniorRenewCount;

		public ushort m_nSeniorTotalRenewCount;

		public ushort m_nSeniorReceiveCount;

		public ushort m_nAddFarmVisitCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
