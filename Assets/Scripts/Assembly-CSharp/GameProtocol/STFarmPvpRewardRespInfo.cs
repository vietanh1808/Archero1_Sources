using System.IO;

namespace GameProtocol
{
	public sealed class STFarmPvpRewardRespInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nVictoryRewardIdx;

		public uint m_nPvpCoin;

		public ulong m_nFreeTimestamp;

		public ushort m_nDiamondCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
