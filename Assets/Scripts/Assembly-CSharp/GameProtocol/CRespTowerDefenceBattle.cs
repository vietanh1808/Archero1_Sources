using System.IO;

namespace GameProtocol
{
	public sealed class CRespTowerDefenceBattle : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nLeftSweepCnt;

		public uint m_nMaxLayer;

		public string m_strLayerData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
