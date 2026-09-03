using System.IO;

namespace GameProtocol
{
	public sealed class CRespCheckPvpJoin : IProtocol
	{
		public short m_nStatusCode;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
