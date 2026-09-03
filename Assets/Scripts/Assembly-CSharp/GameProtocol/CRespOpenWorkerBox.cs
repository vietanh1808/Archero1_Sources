using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenWorkerBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nWorkerBoxCountLow;

		public ushort m_nWorkerBoxCountMid;

		public ushort m_nWorkerBoxCountHigh;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
