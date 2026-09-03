using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1956 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1956-update";

	private float radius;

	private float fallThunderAtkPercent;

	private int debuff;

	private float atkInterval;

	private int minCount;

	private int initialMaxCount;

	private int deltaLevels;

	private ConditionTime atkCD;

	private GameObject goThunderCircle;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onHeroDrop2Floor()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onUpdate(float obj)
	{
	}

	private void updateDebuff()
	{
	}

	private void updateFallThunderAtk()
	{
	}

	private List<EntityBase> getSelectedEnemies()
	{
		return null;
	}

	private int getMaxCount()
	{
		return 0;
	}

	private void initThunderCircle()
	{
	}

	private void deinitThunderCircle()
	{
	}

	private GameObject createThunderCircle()
	{
		return null;
	}
}
