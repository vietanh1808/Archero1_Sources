using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqActivityChargeOnce : CProtocolBase
	{
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
