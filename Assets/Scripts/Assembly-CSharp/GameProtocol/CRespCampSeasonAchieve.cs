using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonAchieve : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nRewardId;

		public CCampAchieveData[] m_arrayAchieve;

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
