using System.IO;

namespace GameProtocol
{
	public sealed class STRespCampSeasonTeam : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTeamId;

		public STTeamProtoData m_stTeamData;

		public STTeamMemberProtoData[] m_arrayInviteList;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
