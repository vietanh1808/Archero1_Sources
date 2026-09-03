using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityDiamondChoice : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ushort m_nStyle;

		public ulong m_nOpenTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public string m_strActivityTitle;

		public CActivityDiamondChoiceItem[] m_vecItems;

		public string m_strRewardConfig;

		public CRewardItem[] m_vecRewardItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
