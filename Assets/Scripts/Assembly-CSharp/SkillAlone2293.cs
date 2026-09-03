using UnityEngine;

public class SkillAlone2293 : SkillAloneBase
{
	private class SkillEffect2293_GearLayerVO : CustomJsonActionVO
	{
		public int Layers;
	}

	private class SkillEffect2293_BulletEnhancementVO : CustomJsonActionVO
	{
		public bool IsApply;

		public int Layers;
	}

	private float moveUnitDistance;

	private int gearBuffId;

	private float bulletEnhanceDuration;

	private float sizeIncreaseBase;

	private float damageIncreaseBase;

	private float knockbackIncreaseBase;

	private float recountCooldown;

	private const int maxGearLayers = 6;

	private int currentGearLayers;

	private float accumulatedDistance;

	private Vector3 lastPosition;

	private bool isCountingMove;

	private float lastStopTime;

	private float bulletEnhanceEndTime;

	private const string SyncSkill2293_GearLayer = "SyncSkill2293_GearLayer";

	private const string SyncSkill2293_BulletEnhancement = "SyncSkill2293_BulletEnhancement";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnMove(bool isMoving)
	{
	}

	private void AddGearLayer()
	{
	}

	private void DoAddGearLayer()
	{
	}

	private void UpdateBuffEffLevel(int level, int buffId)
	{
	}

	private void ApplyBulletEnhancement()
	{
	}

	private void DoApplyBulletEnhancement()
	{
	}

	private void RemoveBulletEnhancement()
	{
	}

	private void DoRemoveBulletEnhancement()
	{
	}

	private void OnAttackPrePre()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncGearLayer(int layers)
	{
	}

	private void SyncBulletEnhancement(bool isApply, int layers)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
