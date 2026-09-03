using System.IO;

namespace GameProtocol
{
	public sealed class CReqEquipQualityReset : CProtocolBase
	{
		public uint m_nTransID;

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
