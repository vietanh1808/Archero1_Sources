using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqCampSeasonTeam : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public uint m_nId;

		public ulong m_nNum64;

		public string m_strName;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
