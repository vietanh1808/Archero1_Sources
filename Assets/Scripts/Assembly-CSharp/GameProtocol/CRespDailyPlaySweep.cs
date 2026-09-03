using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyPlaySweep : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string jsonDailyInfo;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
