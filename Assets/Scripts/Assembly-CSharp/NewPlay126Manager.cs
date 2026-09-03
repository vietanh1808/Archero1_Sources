using System.Collections.Generic;
using UnityEngine;

public class NewPlay126Manager : CInstance<NewPlay126Manager>
{
	private EntityPartBodyBase mainMonster;

	private List<EntityPartBodyBase> allMonster;

	public const int NewPlay126StoneDropShowID = 6001;

	public const int SkillConfigConfigID = 3363;

	public const int SKillPublicCdConfigID = 3364;

	public const int SlotCountConfigID = 3365;

	public const int NewPlay126PlayerDefaultWeaponConfigID = 3367;

	public const int ChooseMonsterGroupCount = 3;

	private bool haveInit;

	private NewPlay126MonsterEntityGroup entityGroupObj;

	public int recordCurMonsterID;

	public List<int> recordEquipStoneID;

	public LocalSave.LocalNewPlay126VO LocalCache => null;

	protected override void Init()
	{
	}

	protected override void ReLogin()
	{
	}

	protected override void Clear()
	{
	}

	private void OnGameModeInit()
	{
	}

	private void OnGameModeDeInit()
	{
	}

	private void OnGameRoomCompleted()
	{
	}

	public void CloseStoneUIPanel()
	{
	}

	public void OnGameDataClear()
	{
	}

	private void InitLocalData()
	{
	}

	private void ClearLocalData()
	{
	}

	private void CheckPlayerWeapon()
	{
	}

	private void CheckCreateMonsterSelect()
	{
	}

	public void CheckCreateMonster()
	{
	}

	public void ClearAllMonster()
	{
	}

	public void ClearSkillCallMonster()
	{
	}

	public void ClearMainMonster()
	{
	}

	public EntityPartBodyBase CreateKingMonster(float existTime)
	{
		return null;
	}

	public void DeinitKingMonster(EntityPartBodyBase target, int characterID)
	{
	}

	public GameObject CreateMonsterModel(NewPlay126MonsterEntityGroupItemData monsterData, Transform monsterModelParent)
	{
		return null;
	}

	public NewPlay126MonsterEntityGroupData GetNewPlay126MonsterEntityGroupData()
	{
		return null;
	}

	public NewPlay126MonsterRemouldStoneData GetNewPlay126MonsterRemouldStoneData()
	{
		return null;
	}

	public NewPlay126SkillGroupData GetNewPlay126SkillGroupData()
	{
		return null;
	}

	public NewPlay126MonsterEntityGroupItemData GetMonsterData()
	{
		return null;
	}

	public bool IsSelectMonster()
	{
		return false;
	}

	public List<NewPlay126MonsterRemouldStoneDropItemData> GetAllRemouldStone()
	{
		return null;
	}

	public List<NewPlay126MonsterRemouldStoneDropItemData> GetSelectRemouldStone()
	{
		return null;
	}

	public List<NewPlay126MonsterRemouldStoneDropItemData> GetAllUnUseRemouldStone()
	{
		return null;
	}

	public NewPlay126MonsterRemouldStoneDropItemData GetRemouldStone(int id)
	{
		return null;
	}

	public bool IsStoneUsing(NewPlay126MonsterRemouldStoneDropItemData stoneData)
	{
		return false;
	}

	public EntityPartBodyBase GetMainMonster()
	{
		return null;
	}

	public List<EntityPartBodyBase> GetAllMonster()
	{
		return null;
	}

	public int GetRemouldStoneDropItemUniqueID()
	{
		return 0;
	}

	public bool HaveBetterStone(NewPlay126MonsterRemouldStoneDropItemData stone)
	{
		return false;
	}

	public int GetPlayerDefaultWeaponID()
	{
		return 0;
	}

	public int GetPlayerDefaultWeaponSkinID()
	{
		return 0;
	}

	public void OnClickCloseMonsterUI()
	{
	}

	public void OnClickSelectMonsterUI(NewPlay126MonsterEntityGroupItemData monsterData)
	{
	}

	public void DestroyMonsterEntityGroup()
	{
	}
}
