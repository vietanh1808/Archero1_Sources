using System.IO;

namespace GameProtocol
{
	public sealed class CRespRuneCompose : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CRuneItem m_stRuneItem;

		public ulong[] m_vecDeleteRowIDs;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
