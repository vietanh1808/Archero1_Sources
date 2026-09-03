using Guild.Hall;

namespace Habby.GuildSDK.Cache
{
	public class CacheGuildQuestInfo : CacheObject<GuildQuestInfo>
	{
		public GuildQuestInfo questInfo { get; private set; }

		protected override void Cache()
		{
		}
	}
}
