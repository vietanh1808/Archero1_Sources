using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqEquipWish : CProtocolBase
	{
		public ushort m_nRequestType;

		public string m_strEquipList;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
