using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqActivitySuperRoulette : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nTaskIndex;

		public ushort m_nCountRewardIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
