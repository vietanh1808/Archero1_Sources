using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public class STTeamMemberProtoData
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong nMemberRawId;

		public string strMemberName;

		public ulong nJoinTs;

		public uint nTeamId;

		public bool bIsLeader;

		public uint m_nHeadId;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public ushort m_nVipLevel;

		public uint m_nHeroId;

		public uint m_nSkinId;

		public uint m_nWingId;

		public ushort m_WingStar;

		public CArtifact[] m_vecArtifactArray;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
