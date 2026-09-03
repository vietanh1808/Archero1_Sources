using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityWish : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
