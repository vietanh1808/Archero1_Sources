using System;
using System.Collections.Generic;
using UnityEngine;

namespace NewPlay125
{
	public class NewPlay125Manager : CInstance<NewPlay125Manager>
	{
		public const string LOG_TAG = "[NewPlay125]";

		public const string UPDATE_EXP_TAG = "[ExpTrack]";

		public const int BagCoin = 39102;

		public const float AtkRange = 15f;

		public float minY;

		public float maxY;

		public const float GameGuideMaxPointAngle = -10f;

		public const float GameGuideMinPointAngle = 0f;

		public const float GameGuideMinPointRotateTime = 1f;

		public const float GameGuideMinPointMoveTime = 1f;

		private List<BaseController> inGameControllers;

		public BackpackController BackpackController;

		public WeaponController WeaponController;

		public InGameController InGameController;

		public PreGameController PreGameController;

		public Action OnWeaponGridWindowClosed;

		public Action OnStartNewWave;

		public Action<int, int> OnCurWaveCompleted;

		public Action<int, int> OnShowNewPlay125Bag;

		public Action OnCurWaveGoodsAbsorbFinished;

		public Action OnWeaponCombined;

		public Action OnWeaponDeployed;

		public TetrisContainer MainContainer;

		private bool haveInit;

		private int _refreshPrice;

		private bool initialized;

		public LocalSave.LocalNewPlay125VO LocalCache => null;

		private PlayerPrefsMgr PlayerPrefsMgr => null;

		private int NewPlay125GuideStep => 0;

		public int RefreshPrice => 0;

		protected override void Init()
		{
		}

		protected override void ReLogin()
		{
		}

		protected override void Clear()
		{
		}

		private void onInit()
		{
		}

		private void onDeInit()
		{
		}

		private void OnBattleDataReset()
		{
		}

		private void OnGameRoomCompleted()
		{
		}

		private void OnGameReleased()
		{
		}

		private void OnGotoNextRoom(RoomGenerateBase.Room room)
		{
		}

		private void InitCallbacks()
		{
		}

		public void UpdateMonsterAttr(EntityBase monster)
		{
		}

		private void OnSkillLevelUpClosed(int levelupCount)
		{
		}

		private void DeInitCallbacks()
		{
		}

		private void InitControllers()
		{
		}

		private void DeInitControllers()
		{
		}

		private BaseController InitController<T>() where T : BaseController, new()
		{
			return null;
		}

		public bool IsCurWaveFinished()
		{
			return false;
		}

		public void SynExp()
		{
		}

		public void IncreaseCurWave()
		{
		}

		public bool HasGotWeaponsSkin()
		{
			return false;
		}

		public int GetCurrentWeaponSkinId()
		{
			return 0;
		}

		public int GetGameDifficulty()
		{
			return 0;
		}

		public int GetFinishedWave()
		{
			return 0;
		}

		public int GetCurWave()
		{
			return 0;
		}

		public int GetMaxWave()
		{
			return 0;
		}

		public long GetCurrentHP()
		{
			return 0L;
		}

		public long GetMaxHP()
		{
			return 0L;
		}

		public void ShowWeaponGrids()
		{
		}

		public List<TetrisUnitConfig> GetWeaponConfigDataByWeaponType(NewPlay125WeaponType weaponType)
		{
			return null;
		}

		public TetrisUnitConfig GetWeaponConfigDataByWeaponID(int id)
		{
			return null;
		}

		public int GetBagCoinCount()
		{
			return 0;
		}

		public void UpdateBagCoin(int useCount)
		{
		}

		public int GetNeedAddBagCoinCount()
		{
			return 0;
		}

		public Vector3 GetPackLeftTopWorldPos()
		{
			return default;
		}

		public Vector3 GetBottomFirstUnitWorldPos()
		{
			return default;
		}

		public bool GetCanCombineUnits(out Vector3 pos1, out Vector3 pos2)
		{
			pos1 = default;
			pos2 = default;
			return false;
		}

		public bool GetInPackPursePositions(ref List<Vector3> list)
		{
			return false;
		}

		private void OnWeaponCombinedEvent()
		{
		}

		private void OnOnWeaponDeployedEvent()
		{
		}

		public void CheckGuide()
		{
		}

		private void SetGuideStep(int step)
		{
		}

		public void CheckCloseGuide()
		{
		}
	}
}
