using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqHeroFragmentExchange : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTargetId;

		public uint m_nUseId;

		public uint m_nTransID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
