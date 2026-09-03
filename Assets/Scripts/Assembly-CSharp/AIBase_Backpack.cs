using TableTool;
using UnityEngine;

public class AIBase_Backpack : AIDizzyBase
{
	private const int AtkPosY = 18;

	private Vector3 targetPos;

	private bool crossRiver;

	protected Daily_BagShopCharacter backpackMonsterMeta;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void PopulateActions()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	protected virtual Vector3 GetTargetPos()
	{
		return default;
	}

	private ActionSequence getMove2Targetpos()
	{
		return null;
	}

	protected virtual ActionBase GetSelfAI()
	{
		return null;
	}
}
