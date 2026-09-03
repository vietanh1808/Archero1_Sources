using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattlePlayerInfo
	{
		public ulong m_nUserID;

		public string m_strName;

		public uint m_nHeadId;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort m_nPeerage;

		public ushort m_nVipLevel;

		public STShipBattleShipInfoProtoData m_stShipInfoData;

		public uint m_nTalentTotalLevel;

		public uint m_nPower;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
