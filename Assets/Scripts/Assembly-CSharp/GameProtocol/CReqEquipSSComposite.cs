using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqEquipSSComposite : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nId;

		public CEquipComposeData m_stEquipComposeData;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
