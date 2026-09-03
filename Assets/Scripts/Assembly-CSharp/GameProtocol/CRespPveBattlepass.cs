using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveBattlepass : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nBattlepassTag;

		public byte[] m_arrBattlepassMask;

		public bool m_bIsIAPBattlepass;

		public ushort m_nRewardCnt;

		public ulong nStartTimestamp;

		public ulong nEndTimestamp;

		public ushort nExtraCnt;

		public ushort nExtraCondParam;

		public string strReward;

		public CPveBattlePassRewardConf[] m_arrTagInfo;

		public ushort m_nRate;

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
