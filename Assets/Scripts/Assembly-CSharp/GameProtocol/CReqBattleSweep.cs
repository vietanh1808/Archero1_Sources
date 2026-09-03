using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqBattleSweep : CProtocolBase
	{
		public ushort m_nType;

		public ushort m_nId;

		public uint m_nTransId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
