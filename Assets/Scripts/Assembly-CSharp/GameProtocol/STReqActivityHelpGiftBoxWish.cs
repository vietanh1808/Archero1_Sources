using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityHelpGiftBoxWish : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public uint m_nId;

		public uint m_nNum;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
