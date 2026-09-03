using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonPreReward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nActivePoint;

		public string m_strRewardPreview;

		public ulong m_nRewardBits;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
