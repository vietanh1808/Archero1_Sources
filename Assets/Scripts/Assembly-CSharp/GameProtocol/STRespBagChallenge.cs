using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespBagChallenge : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public STBagChallengeShop m_stShop;

		public STChapterPassData m_vecChapterData;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort m_nMaxPassDifficulty;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
