using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqActivityCommon : CProtocolBase
	{
		public ushort m_nRequestType;

		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nRewardId;

		public ushort m_nRewardType;

		public string m_strExtra;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
