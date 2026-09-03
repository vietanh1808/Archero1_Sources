using System.IO;

namespace GameProtocol
{
	public sealed class STCampSeasonBaseBlockRole
	{
		public ulong m_nUserID;

		public string m_strName;

		public uint m_nHeadId;

		public uint m_nHeadFrameId;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort m_nCampHomeLevel;

		public ushort m_nVipLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
