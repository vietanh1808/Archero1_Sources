using System.IO;

namespace GameProtocol
{
	public sealed class CReqShipBattleSeasonFire : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nBombANum;

		public uint m_nBombBNum;

		public uint m_nId;

		public ushort m_nStage;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
