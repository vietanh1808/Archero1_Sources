using System.IO;

namespace GameProtocol
{
	public sealed class CEquipUpgarde : CProtocolBase
	{
		public ulong m_nRowId;

		public uint m_nTransID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
