using System.IO;

namespace GameProtocol
{
	public sealed class STGameFishingRankItem
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

		public ushort m_nVipLevel;

		public uint[] m_vecUsingMedals;

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
