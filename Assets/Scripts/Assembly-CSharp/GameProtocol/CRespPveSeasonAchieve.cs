using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonAchieve : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CPveAchieveData[] m_arrayAchieve;

		public string m_strTaskConfig;

		public CPveAchieveData[] m_arrayHardAchieve;

		public string m_strHardTaskConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
