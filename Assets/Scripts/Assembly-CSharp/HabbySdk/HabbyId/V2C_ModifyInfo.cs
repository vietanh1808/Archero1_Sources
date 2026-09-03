using System;

namespace HabbySdk.HabbyId
{
	public class V2C_ModifyInfo : HIDEvent
	{
		public int? gameUpdatesAndNews;

		public int? eventsAndBonus;

		public int? communityInteraction;

		public int? shopSpecialOffer;

		public int? newsForHabby;

		public Action callback;
	}
}
