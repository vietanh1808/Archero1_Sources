using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqEquipWear : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nShow;

		public string m_strWearInfo;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
