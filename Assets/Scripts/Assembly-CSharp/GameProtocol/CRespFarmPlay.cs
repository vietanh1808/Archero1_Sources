using System.IO;

namespace GameProtocol
{
	public sealed class CRespFarmPlay : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public CFarmEvent[] m_vecFarmEvents;

		public ushort m_nGetRewardType;

		public ulong m_nTimestamp;

		public CMonsterEgg[] m_arrayEgg;

		public CMonsterItem[] m_arrayMonster;

		public ushort m_nVisitCount;

		public ulong m_nBeVisitedUserRawId;

		public string m_nstrNickName;

		public uint m_nHeadIcon;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
