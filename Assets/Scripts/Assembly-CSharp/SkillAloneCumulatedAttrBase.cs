public class SkillAloneCumulatedAttrBase : SkillAloneBase
{
	protected string attrName;

	private float deltaAttackPercent;

	private float maxAttackPercent;

	protected string AttrKey => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void InitCallback()
	{
	}

	protected virtual void DeleteCallback()
	{
	}

	private string getDeltaAtkValueStr(float deltaValue)
	{
		return null;
	}

	protected void AddAttr2Entity()
	{
	}
}
