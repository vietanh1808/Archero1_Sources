using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonArenaTarget : STBaseRank
	{
		public uint m_nMilitary;

		public uint m_nPower;

		public uint m_nScore;

		public int m_nWinScore;

		public int m_nLoseScore;

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
