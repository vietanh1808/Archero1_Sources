using System.IO;

namespace GameProtocol
{
	public sealed class STRespPveSeasonGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nDailyTime;

		public uint m_nOpenGameLevel;

		public STActivityArtifactIdentifyGift m_stGift;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
