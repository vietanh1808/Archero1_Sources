using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqActivityYearAward : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nTag;

		public ushort m_nRewardType;

		public ushort m_nIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
