using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonArenaBattleLog : STBaseRank
	{
		public uint m_nMilitary;

		public uint m_nPower;

		public bool m_bActive;

		public bool m_bWin;

		public int m_nChangeScore;

		public new void ReadFromStream(BinaryReader reader)
		{
		}

		public new void WriteToStream(BinaryWriter writter)
		{
		}

		public new byte[] buildPacket()
		{
			return null;
		}
	}
}
