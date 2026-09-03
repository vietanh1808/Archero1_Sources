using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace Dxx.AntiCheat
{
	public class AntiCheatMediator : Mediator
	{
		public new const string NAME = "AntiCheatMediator";

		public AntiCheatGlobalManager globalManager;

		public override IEnumerable<string> ListNotificationInterests => null;

		public AntiCheatMediator(string name, object view)
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

		private void OnCheckSelfHPInGameOver(bool isFullHP)
		{
		}

		private void onOpenGameOverPanel()
		{
		}

		private void onHeroDrop2Floor()
		{
		}

		private void onIncreasePauseCount()
		{
		}

		private void onPvpAtTheBeginning()
		{
		}

		private void onFoundIllegalCurHp(ObscuredLong body)
		{
		}

		private void onRecordHeroAttrs(ObscuredInt saveAttEnum)
		{
		}

		private PvpHeroAttrVO createPvpHeroAttrVO(EntityAttributeBase attribute)
		{
			return null;
		}

		private void onSaveSkillIds(ObscuredInt saveEnum)
		{
		}

		private void onEnablePvpTimer(bool enable)
		{
		}

		private void onPvpRandomCryptoKey()
		{
		}

		private void onGlobalRandomCryptoKey()
		{
		}

		private void onClearPvpRecordData()
		{
		}

		private void onSavePraticalSkillsAfterPvpFinished(List<ObscuredInt> pvpSkillIds)
		{
		}

		private void onSavePraticalSkillsBeforePvpStarted(List<int> pvpSkillIds)
		{
		}

		private void onSaveSkillIdsInPvp(PvpHeroVO heroVO)
		{
		}
	}
}
