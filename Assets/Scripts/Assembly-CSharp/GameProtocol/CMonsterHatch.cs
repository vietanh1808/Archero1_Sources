using System.IO;

namespace GameProtocol
{
	public sealed class CMonsterHatch : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nId;

		public string m_nStrMonsterBattleInfo;

		public ushort m_nHatchPosition;

		public ulong m_nRowID;

		public uint[] m_vecEquips;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
