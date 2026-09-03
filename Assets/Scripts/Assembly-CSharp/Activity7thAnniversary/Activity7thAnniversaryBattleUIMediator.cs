using System.Collections.Generic;

namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryBattleUIMediator : MediatorBase
	{
		public new const string NAME = "Activity7thAnniversaryBattleUIMediator";

		public override List<string> OnListNotificationInterests => null;

		public Activity7thAnniversaryBattleUIMediator()
			: base(null)
		{
		}
	}
}
