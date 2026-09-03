using System.IO;

namespace GameProtocol
{
	public sealed class STFarmPvpBattleRespInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nDailyCnt;

		public ushort m_nDailyBuyCnt;

		public uint m_nScore;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
