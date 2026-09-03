using System.Collections.Generic;
using Habby.Guild.Data;

namespace Habby.GuildSDK.Cache
{
	public class CacheApplyListObject : CacheObject<ActionList>
	{
		public Dictionary<string, ActionData> userIdToActionData;

		protected override void Cache()
		{
		}

		public void RemoveByUserId(string userId)
		{
		}

		public new void Clear()
		{
		}
	}
}
