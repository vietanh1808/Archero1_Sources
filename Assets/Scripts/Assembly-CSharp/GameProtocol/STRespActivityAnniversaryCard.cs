using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityAnniversaryCard : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public string m_strStatJson;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
