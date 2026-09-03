using System.IO;

namespace GameProtocol
{
	public sealed class STReqFarmPvpBattleInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransId;

		public string m_strExtraInfo;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
