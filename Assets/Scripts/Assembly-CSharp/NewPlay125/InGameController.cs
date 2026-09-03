namespace NewPlay125
{
	public class InGameController : BaseController
	{
		public const int DEFAULT_WEAPON_EQUIP_ID = 1010104;

		private EntityHero m_Entity;

		private InGameVO m_inGameVO;

		private AllWeaponSkinsCtrl m_allWeaponSkinsCtrl;

		private WavesController m_wavesController;

		public InGameVO InGameVO => null;

		public WavesController WavesController => null;

		public override void InitGame()
		{
		}

		public override void RestoreFromCache()
		{
		}

		public override void DeInitGame()
		{
		}

		public override void Sync2Cache()
		{
		}

		public void OnGameRoomCompleted()
		{
		}

		public void OnWeaponSkinSelected(int weaponSkinId)
		{
		}

		public void OnNoWeaponSkinSelected()
		{
		}

		private void commonInit()
		{
		}

		private void initMaxWave()
		{
		}

		private void initWeaponSkins()
		{
		}

		private void OnWeaponSkinTriggered(EventWeaponSkinCtrl ctrl)
		{
		}

		private AllWeaponSkinsCtrl getAllWeaponSkinsCtrl()
		{
			return null;
		}

		private void initCallbacks()
		{
		}

		private void deinitCallbacks()
		{
		}

		private void OnWeaponGridWindowClosed()
		{
		}

		private void onGotoNextRoom(RoomGenerateBase.Room room)
		{
		}

		public void IncreaseWave()
		{
		}

		public bool ReachMaxWave()
		{
			return false;
		}

		public int GetNextWave()
		{
			return 0;
		}

		public void UpdateBagCoin(int delta)
		{
		}

		public bool IsGameOver()
		{
			return false;
		}

		public void EndGame()
		{
		}
	}
}
