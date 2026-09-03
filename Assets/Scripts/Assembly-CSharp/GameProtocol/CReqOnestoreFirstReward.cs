using System.IO;

namespace GameProtocol
{
	public sealed class CReqOnestoreFirstReward : CProtocolBase
	{
		private enum EOnestoreOpType
		{
			EQueryType = 0,
			EGainType = 1,
			EInvalidateType = 2
		}

		public uint m_nTransId;

		public ushort m_nType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
