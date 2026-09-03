using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqBuyItem : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nItemId;

		public uint m_nItemCount;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
