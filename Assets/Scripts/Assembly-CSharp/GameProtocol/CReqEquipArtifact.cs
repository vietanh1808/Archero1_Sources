using System.IO;

namespace GameProtocol
{
	public sealed class CReqEquipArtifact : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nArtifactId;

		public ulong m_nRowID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
