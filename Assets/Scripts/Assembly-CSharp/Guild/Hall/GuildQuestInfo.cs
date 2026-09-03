namespace Guild.Hall
{
	public class GuildQuestInfo
	{
		public GuildQuestItemData[] questItemList;

		public int refCount;

		public ulong refTime;

		public GuildQuestItemData this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GuildQuestInfo(string jsonData)
		{
		}

		public GuildQuestInfo()
		{
		}

		public void SetJsonData(string jsonData)
		{
		}

		public int GetCanRewardCount()
		{
			return 0;
		}

		public void Copy(GuildQuestInfo pInfo)
		{
		}
	}
}
