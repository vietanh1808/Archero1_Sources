using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenEquipSBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nEndTime;

		public ushort m_nEquipSBoxCountLow;

		public ushort m_nEquipSBoxCountHigh;

		public string m_strActivityEquipSUp;

		public ushort m_nEquipSBoxCountActivity;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
