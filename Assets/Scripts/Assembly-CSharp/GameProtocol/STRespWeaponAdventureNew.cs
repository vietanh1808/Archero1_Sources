using System.IO;

namespace GameProtocol
{
	public sealed class STRespWeaponAdventureNew : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public STAdventurePassData m_vecAdventureData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
