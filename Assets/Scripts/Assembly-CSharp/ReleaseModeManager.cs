using System;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseModeManager
{
	private GameMode mMode;

	private DeadGoodMgr mDeadGoodMgr;

	private Transform goodsParent;

	private GameObject MoveJoy;

	private float mStartTime;

	private bool mIsFirstPlay;

	private RoomGenerateBase _RoomGenerate;

	private GameDataCache _GameDataCache;

	private int noobSkillTimes;

	public Action OnGotoNextRoomBefore;

	public Action<bool> OnRoomDoorOpenChange;

	public Action<RoomGenerateBase.Room> OnGotoNextRoom;

	public Action<RoomGenerateBase.Room> OnGotoNextRoomAfter;

	public Action<RoomGenerateBase.Room> OnOpenDoor;

	public Action OnTDWaveFinished;

	public Action OnFindPathRectChanged;

	public Action OnHeroDrop2Floor;

	public Action<EntityBase, EntityBase> OnKillAction;

	public Action<EntityBase, HitStruct, HittedData> OnHitAction;

	public Action<int> onChangeHero;

	public Action OnCreatePlayerEvent;

	public Action<EntityBase> OnCreatePlayerEntityEvent;

	public Action OnCreatePlayerEventWithoutCache;

	public Action<EntityBase> onEntityCreate;

	public Action<List<MapCreator.GoodsInfo>> onWaveCreated;

	public Action onGameType5WaveCreated;

	public Action OnEventMissAction;

	public Action<int, int, int> OnSpecialGoodsEvent;

	public Action<EntityBase, EntityBase, HitStruct> OnEntityDead;

	public Action<EntityBase> OnMonsterDead;

	public Action<EntityBase> OnMonsterDeadFinalCallback;

	public Action<EntityBase> OnMonsterWillDead;

	public Action<bool> OnAddExpAnimFinished;

	public Action OnNewPlay114BossChoosed;

	public Action<EventWindowCtrl> OnEventNPCStartDisappear;

	public Action OnBattleStageAssigned;

	public Action OnGameModeCreated;

	public Action OnBattleDataReset;

	public Action OnWillCreatePlayer;

	public Action OnGameRoomCompleted;

	public Action OnGameReleased;

	public Action OnCreatePlayerEnd;

	public RoomGenerateBase RoomGenerate => null;

	public DeadGoodMgr DeadGoodManager => null;

	public GameDataCache GameDataCache => null;

	public bool IsSailingBagBattleMode => false;

	private void onAfterBattleDataReset()
	{
	}

	private void onAfterBattleDataResetInDailySanta2023()
	{
	}

	private void onAfterBattleDataResetInDaily125()
	{
	}

	private void tryOptimizedPool()
	{
	}

	public void Init()
	{
	}

	private void PreloadAtlas()
	{
	}

	private void createPlayerWrapper()
	{
	}

	private void onAfterPlayerCreatedWithoutCache()
	{
	}

	private void initDragonUICtrl()
	{
	}

	private void learnPetStarSkills()
	{
	}

	private bool canOpenPet()
	{
		return false;
	}

	private void initBattlePetsUICtrl()
	{
	}

	private bool TryApplyBattleSystemPetSkillsDecision()
	{
		return false;
	}

	public void DeInit()
	{
	}

	public void ClearGameDataCache()
	{
	}

	private void init_battlestage()
	{
	}

	private void OnGotoNextDoorAfter(RoomGenerateBase.Room room)
	{
	}

	private void OnGotoNextRoomEvent(RoomGenerateBase.Room room)
	{
	}

	public int GetCurrentRoomID()
	{
		return 0;
	}

	public GameMode GetMode()
	{
		return (GameMode)0;
	}

	private void SwitchMode()
	{
	}

	private void SwitchModeNotGuide()
	{
	}

	private void GuideEndAction()
	{
	}

	private void CreatePlayer()
	{
	}

	public void CreateJoy()
	{
	}

	public GameObject GetMoveJoy()
	{
		return null;
	}

	public void SetGoodsParent(Transform parent)
	{
	}

	public Transform GetGoodsParent()
	{
		return null;
	}

	public void EnterDoor()
	{
	}

	public void EnterPortalDoor(int line)
	{
	}

	public void CreateGoods(Vector3 pos, List<BattleDropData> goodslist, int radius)
	{
	}

	public void PlayerDead()
	{
	}

	public bool ForceLevelUp(int level)
	{
		return false;
	}

	public void RemoveSkill(int skillId)
	{
	}

	public bool ForceNoobSkill()
	{
		return false;
	}

	public List<int> GetNoobSkill9()
	{
		return null;
	}

	public void OnCreateMonster(EntityBase entity)
	{
	}

	public void OnWaveCreatedFunc(List<MapCreator.GoodsInfo> list)
	{
	}
}
