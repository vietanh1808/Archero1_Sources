using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityFifthAnniversary : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nRewardType;

		public int m_nId;

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
