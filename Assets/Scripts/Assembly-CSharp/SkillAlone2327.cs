using System.Collections.Generic;
using TableTool;

public class SkillAlone2327 : SkillAlonePetBase
{
	private class StackAttrData
	{
		public float expireTime;

		public Goods_goods.GoodData elementDmgData;

		public Goods_goods.GoodData atkSpeedData;
	}

	private float moveInterval;

	private int maxStacks;

	private float stackDuration;

	private float elementDmgBase;

	private float elementDmgGrowth;

	private float atkSpeedBase;

	private float atkSpeedGrowth;

	private float meteorProbability;

	private float meteorDmgCoefficient;

	private int[] allBulletID;

	private float dropRadius;

	private int starMin;

	private int starMax;

	private int starlightCloakBuffId;

	private float mutation20MeteorProbability;

	private float moveTimer;

	private int currentStacks;

	private bool isHeroMoving;

	private List<StackAttrData> stackAttrList;

	private bool cloakApplied;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMoveEvent(bool moving)
	{
	}

	private void OnGotNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void AddStarlightStack()
	{
	}

	private void RemoveExpiredStacks(bool forceRemove = false)
	{
	}

	private void RemoveStackAttr(StackAttrData data)
	{
	}

	private void RemoveAllStackAttrs()
	{
	}

	private void TryCreateMeteor()
	{
	}
}
