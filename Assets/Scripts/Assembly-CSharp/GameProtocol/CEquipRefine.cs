using System.IO;

namespace GameProtocol
{
	public sealed class CEquipRefine : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nPosId;

		public uint m_nCarvingId;

		public ushort m_nCarvingIdx;

		public ulong[] arrayEquipId;

		public uint[] vecCompositeId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
