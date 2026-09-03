using System.IO;

namespace GameProtocol
{
	public sealed class STActivityDailyPlayStage130RankItem : STBaseRank
	{
		public uint[] m_vecUsingMedals;

		public uint m_nHeroId;

		public uint m_nSkinId;

		public uint m_nWingId;

		public ushort m_nWingStar;

		public CArtifact[] m_vecArtifactInfos;

		public ulong[] m_vecDamages;

		public new void ReadFromStream(BinaryReader reader)
		{
		}

		public new void WriteToStream(BinaryWriter writer)
		{
		}

		public new byte[] buildPacket()
		{
			return null;
		}
	}
}
