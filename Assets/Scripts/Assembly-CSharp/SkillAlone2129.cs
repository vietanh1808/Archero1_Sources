using System.Collections.Generic;

public class SkillAlone2129 : SkillAloneBase
{
	private int arrowShowerCallProb;

	private float arrowShowerRadius;

	private float arrowShowerLastTime;

	private float arrowShowerDmgInterval;

	private float arrowShowerDmgScale;

	private float arrowShowerCreateInterval;

	private float arrowShowerLastCreateTime;

	protected virtual int SkillEffectID => 0;

	protected virtual bool AllowCreateArrowShower => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	protected virtual EElementType GetElementType()
	{
		return EElementType.eNone;
	}

	protected virtual List<int> GetBuffID()
	{
		return null;
	}

	protected virtual bool AllowCrit()
	{
		return false;
	}

	protected virtual SkillAlone2129GoodCtrl CastSkill(EntityBase target)
	{
		return null;
	}
}
