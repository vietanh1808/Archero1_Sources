using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqDailyPlaySweep : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public uint m_nId;

		public uint m_nDifficultId;

		public uint m_nMazeMode;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
