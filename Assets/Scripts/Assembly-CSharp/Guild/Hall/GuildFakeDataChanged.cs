namespace Guild.Hall
{
	public class GuildFakeDataChanged
	{
		public enum ChangedType
		{
			none = 0,
			donateCount = 1,
			daySigin = 2,
			weekSigin = 3,
			guildLevel = 100,
			score = 101,
			guildXp = 102,
			help = 103,
			memberCount = 104
		}

		public ChangedType type;

		public int addValue;
	}
}
