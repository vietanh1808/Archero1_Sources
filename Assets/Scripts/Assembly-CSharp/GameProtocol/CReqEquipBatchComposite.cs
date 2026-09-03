using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqEquipBatchComposite : CProtocolBase
	{
		public uint m_nTransID;

		public CEquipComposeData[] m_vecEquipComposeData;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
