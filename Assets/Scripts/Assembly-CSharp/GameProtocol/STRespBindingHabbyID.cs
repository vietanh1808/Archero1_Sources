using System.IO;

namespace GameProtocol
{
	public sealed class STRespBindingHabbyID : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public bool m_bRewardReceived;

		public string m_strHabbyID;

		public string m_strRewardCfg;

		public uint m_nOpenGameLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
