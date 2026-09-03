using System.Collections.Generic;

public class SkillAlone1744 : SkillAloneBase
{
	private int createStarProbability;

	private float createInterval;

	private float selfRotateSpeed;

	private float rotateSpeed;

	private float rotateRadius;

	private float dmgCoeff;

	private int starTriggerCount;

	private int buffID;

	private float scale;

	private float coolingTime;

	private float lastCreateStarTime;

	private float recordTime;

	private List<SkillAlone1744GoodCtrl> createList;

	private LocalSave.Skill1744VO Skill1744VO => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void HitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void RandomCreateChickenLeg()
	{
	}

	private bool SendCreateStarMsg()
	{
		return false;
	}

	private void SyncCreateStar(EntityBase entity)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void CreateStar(EntityBase entity)
	{
	}

	private void InitStar()
	{
	}

	private void CheckAbsorbStar()
	{
	}

	private void AbsorbStar()
	{
	}
}
