using UnityEngine;

public class SkillAlone1717 : SkillAloneBase
{
	private const string UPDATE_NAME = "1717-Update";

	private const string HPDROP_KEY = "1717-HPDROP_KEY";

	private float disguiseTime;

	private float stopDisguiseTime;

	private float baseRate;

	private float deltaRate;

	private float maxRate;

	private int[] monsterIds;

	private int[] buffIds;

	private int[] moveBuffIds;

	private bool IsDisguised;

	private float curDisguiseTime;

	private float curStopDisguiseTime;

	private int curIndex;

	private int curHPDrop;

	public BodyMask curMonster;

	public DisguiseCDSlider slider;

	public bool IsMoving;

	private EntityHero m_hero;

	private int monsterId;

	protected override void OnInstall()
	{
	}

	private void onWuKongCloudEnd()
	{
	}

	private void onWuKongCloudStart()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onWillStartSphereFlash()
	{
	}

	private void OnCancelDisguisedManually()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void OnAbsorbHpFood(FoodBase @base)
	{
	}

	private void parseArgs0(string[] strs)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void cancelDisguise()
	{
	}

	private void OnMoveEvent(bool _isMoving)
	{
	}

	private void OnLevelup(int obj)
	{
	}

	private void OnMissAngel()
	{
	}

	private void TryDisguise()
	{
	}

	private DisguiseCDSlider createSlider()
	{
		return null;
	}

	private GameObject createMonster(int monsterId)
	{
		return null;
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	private void SetHeroVisible(bool visible, float alpha)
	{
	}

	private void playMonsterAnim(string animStr)
	{
	}

	private void syncMonsterRotation()
	{
	}

	private void addBuff()
	{
	}

	private void addMoveBuff()
	{
	}

	private void removeMoveBuff()
	{
	}
}
