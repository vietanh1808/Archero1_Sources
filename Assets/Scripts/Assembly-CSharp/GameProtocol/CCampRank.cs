using System.IO;

namespace GameProtocol
{
	public sealed class CCampRank
	{
		public ulong m_nUserID;

		public uint m_nRank;

		public ulong m_nValue;

		public string m_strName;

		public uint m_nHeadId;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort m_nPeerage;

		public ushort m_nVipLevel;

		public ushort m_nCamp;

		public uint m_nHeroId;

		public uint m_nSkinId;

		public uint m_nWingId;

		public ushort m_WingStar;

		public CArtifact[] m_vecArtifactArray;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
