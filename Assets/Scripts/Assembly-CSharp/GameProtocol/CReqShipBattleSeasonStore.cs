using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqShipBattleSeasonStore : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nId;

		public ushort m_nCount;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
