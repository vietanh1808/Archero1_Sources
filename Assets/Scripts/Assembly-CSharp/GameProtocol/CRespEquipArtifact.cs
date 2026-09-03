using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipArtifact : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CArtifact[] m_arrayArtifact;

		public ulong m_nRowID;

		public ushort m_nStarId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
