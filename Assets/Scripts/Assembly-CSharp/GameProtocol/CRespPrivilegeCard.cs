using System.IO;

namespace GameProtocol
{
	public sealed class CRespPrivilegeCard : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nNormalExpireTime;

		public bool m_bNormalRewardReceived;

		public ulong m_nBigExpireTime;

		public bool m_bBigRewardReceived;

		public ulong m_nNormalStartTime;

		public ulong m_nNormalEndTime;

		public ulong m_nBigStartTime;

		public ulong m_nBigEndTime;

		public string m_strPrivilegeCardConfig;

		public string m_strPrivilegeCardPowerConfig;

		public ulong m_nLifetimeExpireTime;

		public ulong m_nLifetimeStartTime;

		public ulong m_nLifetimeEndTime;

		public bool m_bLifetimeRewardReceived;

		public ulong m_nDiamondLifetimeExpireTime;

		public bool m_bDiamondLifetimeRewardReceived;

		public ulong m_nDiamondLifetimeStartTime;

		public ulong m_nDiamondLifetimeEndTime;

		public uint m_nDiamondLifetimeReceiveTimes;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
