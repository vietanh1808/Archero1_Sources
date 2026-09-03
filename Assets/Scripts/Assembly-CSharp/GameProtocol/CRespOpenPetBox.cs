using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenPetBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nEndTime;

		public ushort m_nPetBoxCountLow;

		public ushort m_nPetBoxCountMid;

		public ushort m_nPetBoxCountHigh;

		public string m_strActivityPetUp;

		public ushort m_nPetBoxCountActivity;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
