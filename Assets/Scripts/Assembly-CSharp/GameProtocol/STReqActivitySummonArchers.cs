using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivitySummonArchers : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public int m_nId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
