using System.IO;

namespace GameProtocol
{
	public sealed class CRespHeroSkin : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CHeroSkin[] m_arraySkin;

		public ushort m_nCollectLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
