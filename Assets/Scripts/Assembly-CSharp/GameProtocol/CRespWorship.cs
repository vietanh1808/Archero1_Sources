using System.IO;

namespace GameProtocol
{
	public sealed class CRespWorship : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CRewardItem m_stRewardItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
