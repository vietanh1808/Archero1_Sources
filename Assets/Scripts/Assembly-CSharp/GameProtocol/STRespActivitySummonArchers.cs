using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivitySummonArchers : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public ushort m_nLayerGameLevel;

		public ushort m_nMaxGameLevel;

		public STActivitySummonArchersTask m_stTask;

		public STActivitySummonArchersRank m_stRank;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
