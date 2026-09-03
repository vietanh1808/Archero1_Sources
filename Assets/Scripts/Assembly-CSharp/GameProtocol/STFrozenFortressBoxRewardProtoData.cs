using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STFrozenFortressBoxRewardProtoData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nID;

		public uint nRewardType;

		public uint nPoints;

		public uint nRepeatPoint;

		public uint nRepeatMax;

		public string strBoximg;

		public uint[][] m_vecRewards;

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
