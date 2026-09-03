using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenDragonBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nDragonBoxCountLow;

		public ushort m_nDragonBoxCountMid;

		public ushort m_nDragonBoxCountHigh;

		public string m_strActivityDragonUp;

		public ushort m_nDragonBoxCountActivity;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
