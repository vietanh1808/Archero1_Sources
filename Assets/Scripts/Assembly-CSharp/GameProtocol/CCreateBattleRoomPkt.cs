using System.IO;

namespace GameProtocol
{
	public sealed class CCreateBattleRoomPkt : CProtocolBase
	{
		public string m_roomId;

		public uint m_nClientVersion;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
