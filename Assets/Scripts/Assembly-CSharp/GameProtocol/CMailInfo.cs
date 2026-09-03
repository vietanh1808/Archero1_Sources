using System.Collections.Generic;
using System.IO;
using Habby.Model;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class CMailInfo : IMailInfo
	{
		public enum eMailType
		{
			ENormalMailType = 1,
			EReimburseMailType = 2,
			eForcePopType = 3,
			EInvalidMailType = 4
		}

		public bool IsReaded;

		public bool IsGot;

		public uint m_nMailID;

		public string m_strTitle;

		public string m_strContent;

		public ushort m_nMailType;

		public ulong m_i64PubTime;

		public ushort m_nCoins;

		public ushort m_nDiamond;

		public CEquipmentItem[] m_arrayEquipItems;

		[JsonIgnore]
		public uint MailID => 0u;

		[JsonIgnore]
		public int MailScope => 0;

		[JsonIgnore]
		public int MailType => 0;

		[JsonIgnore]
		public string Title => null;

		[JsonIgnore]
		public string Content => null;

		[JsonIgnore]
		public string BeginTime => null;

		[JsonIgnore]
		public string EndTime => null;

		[JsonIgnore]
		public bool IfReaded => false;

		[JsonIgnore]
		public bool IfReceived => false;

		[JsonIgnore]
		public bool IfHaveReward => false;

		[JsonIgnore]
		public bool IfShowRed => false;

		[JsonIgnore]
		public MailReward[] Rewards => null;

		[JsonIgnore]
		public bool IsHaveReward => false;

		[JsonIgnore]
		public bool IsShowRed => false;

		public static MailReward[] GetRewardsByInfo(CMailInfo mailInfo)
		{
			return null;
		}

		public static List<IMailInfo> GetMailInfosByList(List<CMailInfo> infoList)
		{
			return null;
		}

		public string GetRewardsString()
		{
			return null;
		}

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private bool checkValid()
		{
			return false;
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
