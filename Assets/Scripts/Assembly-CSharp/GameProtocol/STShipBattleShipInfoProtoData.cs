using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STShipBattleShipInfoProtoData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nShipLevel;

		public uint m_nShipSkin;

		public uint m_nShipSpeed;

		public STRespShipComponentData[] m_vecRespShipComponentDatas;

		public STRespShipRoomData[] m_vecRespShipRoomDatas;

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
