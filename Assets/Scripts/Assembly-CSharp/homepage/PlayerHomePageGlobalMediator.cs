using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace homepage
{
	public class PlayerHomePageGlobalMediator : Mediator
	{
		public new const string NAME = "PlayerHomePageGlobalMediator";

		public override IEnumerable<string> ListNotificationInterests => null;

		public PlayerHomePageGlobalMediator(string name, object view)
		{
		}

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		public override void HandleNotification(INotification notification)
		{
		}

		private void openNameCard(ulong longUserId)
		{
		}

		private void checkIfSyncEquips()
		{
		}

		private void trySyncPartEquips()
		{
		}
	}
}
