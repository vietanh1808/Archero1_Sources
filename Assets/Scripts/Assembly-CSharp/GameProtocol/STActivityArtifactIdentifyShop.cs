using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STActivityArtifactIdentifyShop : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public STCommonShopData[] m_vecShopData;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
