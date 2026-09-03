using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityLuckPlinko : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public int m_nId;

		public int m_nNum;

		public int m_nThrowNum;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
