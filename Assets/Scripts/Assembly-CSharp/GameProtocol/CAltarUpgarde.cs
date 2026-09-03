using System.IO;

namespace GameProtocol
{
	public sealed class CAltarUpgarde : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ulong[] m_vecERowID;

		public uint[] m_vecItems;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
