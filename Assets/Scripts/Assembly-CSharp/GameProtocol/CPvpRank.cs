using System.IO;

namespace GameProtocol
{
	public sealed class CPvpRank
	{
		public ulong m_nUserID;

		public uint m_nRank;

		public uint m_nScore;

		public string m_strName;

		public uint m_nHeadId;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public uint m_nCount;

		public uint m_nWinCount;

		public uint m_nWinMaxCount;

		public ushort m_nVipLevel;

		public uint[] m_vecUsingMedals;

		public int[] m_vecCoopHeros;

		public CEquipmentItem[] m_vecEquipmentData;

		public string m_strWearInfo;

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
