using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqShipBattleSeasonFight : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public ulong m_nTargetUserRawId1;

		public ulong m_nTargetUserRawId2;

		public uint m_nSeed;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
