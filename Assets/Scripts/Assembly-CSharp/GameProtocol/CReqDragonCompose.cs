using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqDragonCompose : CProtocolBase
	{
		public uint m_nTransID;

		public CDragonComposeData[] m_vecEquipComposeData;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
