using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityAnniversary : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nPos;

		public ushort m_nRewardType;

		public ushort m_nTaskId;

		public int m_nBoxRewardId;

		public ushort m_nExchangeId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
