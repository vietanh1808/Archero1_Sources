using System.IO;

namespace GameProtocol
{
	public sealed class CRespQueryOtherUser : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strNickName;

		public uint m_nHeadIcon;

		public uint m_nHeadFrame;

		public ushort m_nMaxLayer;

		public ushort m_nLevel;

		public CHeroItem[] m_arrayHeroData;

		public CHeroSkin[] m_arraySkin;

		public CMonsterItem[] m_arrayMonster;

		public CEquipmentItem[] m_arrayEquipData;

		public string m_strWearInfo;

		public ushort m_nSrvMaxChapter;

		public ushort m_nSrvMaxHeroCnt;

		public ushort m_nSrvMaxMonsterCnt;

		public ushort m_nSrvMaxSkinCnt;

		public uint[] m_vecUsingMedals;

		public string m_strEquipCarving;

		public uint[] m_vecBattlePets;

		public ushort m_nBeliefLevel;

		public ushort m_nHellMaxLayer;

		public ushort m_nLayerShowType;

		public CArtifact[] m_arrayArtifact;

		public ushort m_WingStar;

		public uint m_nCardThemeId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
