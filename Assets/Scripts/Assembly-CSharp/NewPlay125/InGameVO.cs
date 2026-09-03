namespace NewPlay125
{
	public class InGameVO : BaseVO
	{
		public const int BATTLE_ROOM_ID = 1;

		private int m_maxWave;

		private int m_finishedWave;

		protected int[] m_weaponSkinIds;

		protected int m_defaultWeaponId;

		protected int m_curWeaponId;

		protected int m_curWeaponSkinId;

		public int BagCoin => 0;

		public int MaxWave => 0;

		public int CurWave => 0;

		public int FinishedWave => 0;

		public int[] WeaponSkinIds => null;

		public int DefaultWeaponId => 0;

		public int CurWeaponId => 0;

		public int CurWeaponSkinId => 0;

		public override void Init()
		{
		}

		public override void DeInit()
		{
		}

		public override void RestoreFromCache()
		{
		}

		public void SetWeaponId(int value)
		{
		}

		public void SetWeaponSkinId(int value)
		{
		}

		private void initWeaponSkinIds()
		{
		}

		private void initDefaultWeaponId()
		{
		}

		public void SetFinishedWave(int wave)
		{
		}

		public void IncreaseFinishedWave()
		{
		}

		public void SetMaxWave(int wave)
		{
		}

		public void UpdateBagCoin(int delta)
		{
		}
	}
}
