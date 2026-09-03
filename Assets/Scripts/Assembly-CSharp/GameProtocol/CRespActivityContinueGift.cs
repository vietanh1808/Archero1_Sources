using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityContinueGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nOpenTime;

		public ulong m_nNoPushTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public string m_strRewards;

		public ushort m_nMaxUnlockGiftId;

		public ulong m_nGiftHideTime;

		public uint m_nBuyRecordBit;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
