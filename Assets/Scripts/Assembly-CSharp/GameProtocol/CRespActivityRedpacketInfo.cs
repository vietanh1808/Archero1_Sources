using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityRedpacketInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ushort m_nLayerIndex;

		public uint m_nTotalRedpacktCnt;

		public uint m_nMaxRedpacketId;

		public Dictionary<uint, ushort> mapSendCnt;

		public Dictionary<uint, ushort> mapOpenCnt;

		public Dictionary<uint, ushort> mapExchangeCnt;

		public CRedpacketUser[] arrayUserInfo;

		public CRedpacketInfo[] arrayRedpacketInfo;

		public uint m_nGroupId;

		public string m_strGiftJson;

		public string m_strGiftBuyCnt;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
