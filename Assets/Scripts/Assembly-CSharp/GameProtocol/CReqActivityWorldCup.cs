using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqActivityWorldCup : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nId;

		public uint m_nTransID;

		public short m_nResultType;

		public ushort m_nBetAdd;

		public ushort[] arrayMatchType;

		public uint[] arrayRewardArgs;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
