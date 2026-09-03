using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipTotem : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CTotem[] m_arrayTotem;

		public ulong m_nDailyTime;

		public int m_nUsedeUpgradeFreeTimes;

		public ushort m_nIsFree;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
