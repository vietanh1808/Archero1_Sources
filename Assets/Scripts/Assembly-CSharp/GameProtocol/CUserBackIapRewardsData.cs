using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CUserBackIapRewardsData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public string productId;

		public string m_strRewards;

		public ushort m_nRate;

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
