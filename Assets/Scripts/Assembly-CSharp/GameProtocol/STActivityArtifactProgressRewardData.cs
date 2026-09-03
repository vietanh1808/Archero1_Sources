using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STActivityArtifactProgressRewardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nID;

		public uint m_nProgress;

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
