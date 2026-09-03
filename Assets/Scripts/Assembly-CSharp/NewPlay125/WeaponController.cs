using System;
using System.Collections.Generic;

namespace NewPlay125
{
	public class WeaponController : BaseController
	{
		private List<NewPlay125WeaponSkillItemData> skillItemData;

		public List<int> waitAddSkill;

		public bool isBoomerangChange;

		public bool isElfBulletChange;

		public bool isElfBulletAddHitReduce;

		public float elfBulletAddHitReduce;

		public float elfBulletAddHitReduceMax;

		public Action<int, int> OnNewPlay125ElfSendBullet;

		public Func<int, long> OnNewPlay125WandBulletBoom;

		public Action OnElfAttackValueChange;

		public Action OnElfAttackSpeedChange;

		public Dictionary<int, int> weaponLearnSkill;

		public override void InitGame()
		{
		}

		public override void DeInitGame()
		{
		}

		public override void RestoreFromCache()
		{
		}

		public override void Sync2Cache()
		{
		}

		private void Init()
		{
		}

		private void Clear()
		{
		}

		private void CheckAddBagCoin()
		{
		}

		private void UpdateSkillCDTime(float delta)
		{
		}

		private NewPlay125WeaponSkillItemData ParseWeaponSkillItemData(int weaponConfigID)
		{
			return null;
		}

		private void RefreshSaveSelectSkill()
		{
		}

		public void OnWaveGameStart(List<int> weaponID)
		{
		}

		private void OnWaveGoodsAbsorbed()
		{
		}

		private void OnWaveGameEnd(int finishedWave, int maxWave)
		{
		}

		private void OnWaveGameEndImmediately(int finishedWave, int maxWave)
		{
		}

		private void SetWeaponSkillData(List<int> weaponID)
		{
		}

		public List<NewPlay125WeaponSkillItemData> GetWeaponSkillItemData()
		{
			return null;
		}

		public List<NewPlay125WeaponSkillItemData> GetWeaponSkillItemDataByWeaponType(NewPlay125WeaponType weaponType)
		{
			return null;
		}

		public float GetWeaponAttributeValue(NewPlay125WeaponSkillAttributeType type)
		{
			return 0f;
		}

		public void ClearWeaponData()
		{
		}

		private long OnNewPlay125WandBulletBoomEvent(int bulletID)
		{
			return 0L;
		}
	}
}
