using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampTalent : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTeamTalentPoint;

		public uint m_nRewardId;

		public uint m_nDonateTeamPoint;

		public CCampTalent[] m_arrayTalent;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
