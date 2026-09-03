using UnityEngine;

public class RoomGenerateLevel : RoomGenerateBase
{
	private new int opendoorIndex;

	private bool bFirstOpen;

	private float m_fRoomStartTime;

	private long m_lRoomStartHp;

	private int bossdeadecentid;

	private Material _hellEffect;

	private int curMapAddSkill;

	protected override void OnInit()
	{
	}

	protected override void OnStartGame()
	{
	}

	protected override void OnStartGameEnd()
	{
	}

	private bool show_first_gold_turn()
	{
		return false;
	}

	private void room_update()
	{
	}

	protected override void OnEnterDoorBefore()
	{
	}

	protected override void OnEnterDoorAfter()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override bool gotonextdoor_canopen()
	{
		return false;
	}

	public override bool CanOpenDoor()
	{
		return false;
	}

	protected override void OnOpenDoor()
	{
	}

	private int getGoodX()
	{
		return 0;
	}

	private void OnHeroReborn()
	{
	}

	private void OnHeroDead()
	{
	}

	private void SendBigMapLayerEndEvent(bool result)
	{
	}

	protected override void OnEventClose(EventCloseTransfer data)
	{
	}

	protected override void OnDeInit()
	{
	}

	private new bool IsBossRoom(int roomid)
	{
		return false;
	}

	public override bool IsLastRoom()
	{
		return false;
	}

	protected override void OnMonsterDead(EntityBase entity)
	{
	}

	private void ShowEvent()
	{
	}

	public override void PlayerDead()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void SendSDKGameOverPoint()
	{
	}

	protected override void OnReceiveEvent(string eventName, object data)
	{
	}

	private void CheckHellEffect()
	{
	}

	protected override void OnCreateMap(Room room)
	{
	}

	public void ShowHellEffect(Room room)
	{
	}

	public void CacheHellEffect()
	{
	}

	private void LoadHellSkillEffect(Room room)
	{
	}

	private void CacheHellSkillEffect()
	{
	}

	public void ShowHellEffect(bool show)
	{
	}

	public void CheckHellMode(BattleModuleData battleData, EntityBase entity)
	{
	}
}
