using System.Collections.Generic;
using System.Text;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TableTool;
using UnityEngine;

namespace Daily129
{
	public class Daily129TowerController : Mediator
	{
		private const string TAG = "Daily129TowerController";

		private const int PART_ID = 1867;

		private const int COLUM_CNT = 7;

		private const int ROW_CNT = 2;

		public const int TOWER_RES_ID = 8006;

		private const int PART_CNT = 4;

		private const int MERGE_GUIDE_MAX_COUNT = 2;

		private const float MERGE_GUIDE_MOVE_DURATION = 0.6f;

		private const float MERGE_GUIDE_MOVE_DELAY = 1f;

		private const int Y1 = 18;

		private const int Y2 = 16;

		private List<int> Xs;

		private int[] _TowerIds;

		private Dictionary<string, TowerModel> _dicTowerModels;

		private List<EntityTower8006> _listTowerEntities;

		private List<EntityPartBody1867> _listPartBody1867s;

		private Dictionary<int, List<int>> _dicSkills;

		private Daily129InGameController _inGameController;

		private TowerModel _latestMaxLevelModel;

		private SequencePool mSeqPool;

		private Sequence _mergeGuideSequence;

		private int _mergeGuideCount;

		private bool _mergeGuideActive;

		private EntityPartBody1867 _mergeGuideSource;

		private EntityPartBody1867 _mergeGuideTarget;

		private int _nCallCnt;

		private int _nStrenthCnt;

		public new const string NAME = "Daily129TowerController";

		private StringBuilder _stringBuilder;

		private const int MAX_SKILL_CNT = 3;

		private List<int> _listIds;

		private PlayerTouch _playerTouch;

		private EntityPartBody1867 _tempPartBody1867;

		public int CallCnt => 0;

		public int StrenthCnt => 0;

		public int TowerCount => 0;

		public Dictionary<int, List<int>> LearnedSkills => null;

		public int StrengthenPrice => 0;

		public override IEnumerable<string> ListNotificationInterests => null;

		public Daily129TowerController(string name, object view)
		{
		}

		public void Init(Daily129InGameController inGameController)
		{
		}

		public void DeInit()
		{
		}

		private void OnGotoNextRoomAfter(RoomGenerateBase.Room room)
		{
		}

		private void OnCreateBullet(BulletBase bullet)
		{
		}

		private void OnHitted(HitStruct hs, EntityBase entity)
		{
		}

		private void OnKill(EntityBase entity)
		{
		}

		public List<int> SkinIds(List<int> ids)
		{
			return null;
		}

		public void CreateTower(int x, int y, Vector3? offset = null)
		{
		}

		private void CheckCreateNewTower(Daily_DefenseCoinCost_129 bean)
		{
		}

		public EntityTower8006 GetTarget(EntityBase entity)
		{
			return null;
		}

		public EntityTower8006 GetWalkDownTarget(EntityBase entity)
		{
			return null;
		}

		public string GetTowerDetails()
		{
			return null;
		}

		public string GetLearnedSkillDetails()
		{
			return null;
		}

		public bool CanStrengthen(bool showTips = false)
		{
			return false;
		}

		public (List<int>, List<int>) GetSkills()
		{
			return default;
		}

		public void LearnSkill(int id, int skillId)
		{
		}

		public int CallPrice(out Daily_DefenseCoinCost_129 bean)
		{
			bean = null;
			return 0;
		}

		public bool Call()
		{
			return false;
		}

		private TowerModel RandomTowerModel(string guid = "")
		{
			return null;
		}

		private bool CanUpGrade(string targetGuid, string sourcGuid)
		{
			return false;
		}

		private void CheckCanUpGradeTowers(EntityTower8006 sourceTower, bool show)
		{
		}

		private bool CheckCanUpgradeTowers()
		{
			return false;
		}

		public void Upgrade(string targetGuid, string sourcGuid)
		{
		}

		private void CheckMaxLevel(TowerModel model)
		{
		}

		public EntityPartBody1867 CreatePartBody(EntityTower8006 tower, Vector3? pos)
		{
			return null;
		}

		private void InitMergeGuide()
		{
		}

		private void CheckMergeGuide()
		{
		}

		private bool TrySelectMergeGuidePair(out EntityPartBody1867 source, out EntityPartBody1867 target)
		{
			source = null;
			target = null;
			return false;
		}

		private void StartMergeGuide(EntityPartBody1867 source, EntityPartBody1867 target)
		{
		}

		private Vector3 GetGuideWorldPosition(EntityPartBody1867 partBody, Transform guideTransform)
		{
			return default;
		}

		private void StopMergeGuide(bool recordCount)
		{
		}

		private void OnMergeGuideMergeSuccess()
		{
		}

		public static void Log(string log, string tag = "")
		{
		}

		public static void LogError(string log, string tag = "")
		{
		}

		private void InitPlayerTouch()
		{
		}

		private void OnUpdate(float deltaTime)
		{
		}

		private void OnTouchBegin(GameTouch touch)
		{
		}

		private void OnTouchMove(GameTouch touch)
		{
		}

		private void OnTouchEnd(GameTouch touch)
		{
		}

		private bool CheckPos(GameTouch touch, out EntityTower8006 entity, out Vector3? pos)
		{
			entity = null;
			pos = null;
			return false;
		}

		public override void HandleNotification(INotification notification)
		{
		}
	}
}
