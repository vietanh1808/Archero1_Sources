using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonBattle : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nOccupyValue;

		public uint m_nHonorValue;

		public uint m_nCampIndex;

		public ushort m_nPassBlockLevel;

		public uint m_nExtraOccupyValue;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
