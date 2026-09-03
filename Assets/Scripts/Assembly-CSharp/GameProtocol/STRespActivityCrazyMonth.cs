using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityCrazyMonth : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public STActivityCrazyMonth[] vecActivityCrazyMonth;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
