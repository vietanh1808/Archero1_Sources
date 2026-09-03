using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityLattice : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort[] vecChoices;

		public ushort m_nId;

		public ushort m_nExchangeCnt;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
