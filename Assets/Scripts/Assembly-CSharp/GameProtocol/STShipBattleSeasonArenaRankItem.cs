using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonArenaRankItem : STBaseRank
	{
		public uint m_nMilitary;

		public uint m_nPower;

		public uint m_nScore;

		public uint m_nHeroId;

		public uint m_nSkinId;

		public uint m_nWingId;

		public ushort m_WingStar;

		public uint[] m_vecUsingMedals;

		public CArtifact[] m_vecArtifactArray;

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
