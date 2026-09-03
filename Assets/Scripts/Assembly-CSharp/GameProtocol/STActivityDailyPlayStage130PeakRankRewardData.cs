using System.IO;

namespace GameProtocol
{
	public sealed class STActivityDailyPlayStage130PeakRankRewardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nID;

		public uint m_nRank;

		public uint[][] m_vecRewards;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
