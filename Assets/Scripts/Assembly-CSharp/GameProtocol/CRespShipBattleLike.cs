using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleLike : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CCampLikeRole[] m_vecLikeRole;

		public ushort m_nDoLikeTimes;

		public ushort m_nDoLikeTimesLimit;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
