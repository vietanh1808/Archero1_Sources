using System.IO;

namespace GameProtocol
{
	public sealed class CReqShipBattleBattlepass : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nStage;

		public uint m_nRewardId;

		public ushort m_nRewardIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
