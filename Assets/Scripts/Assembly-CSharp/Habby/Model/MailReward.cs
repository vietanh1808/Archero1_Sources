using System;
using System.Text;
using GameProtocol;
using TableTool;

namespace Habby.Model
{
	[Serializable]
	public sealed class MailReward
	{
		public ulong rowId;

		public int rewardType;

		public uint rewardId;

		public uint rewardLevel;

		public ulong rewardAmount;

		public ulong rewardEffectiveTime;

		public Drop_DropModel.DropData ToDropData()
		{
			return null;
		}

		public CHeroSkin ToHeroSkin()
		{
			return null;
		}

		public CEquipmentItem ToEquipData()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string GetRewardString()
		{
			return null;
		}

		public void AppendRewardString(StringBuilder sb)
		{
		}
	}
}
