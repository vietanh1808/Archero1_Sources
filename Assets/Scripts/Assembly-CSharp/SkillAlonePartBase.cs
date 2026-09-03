using System.Collections.Generic;
using TableTool;

public class SkillAlonePartBase : SkillAloneBase
{
	private const string String_CallID = "CallID";

	private const string String_Time = "Time";

	private const string String_Weight = "Weight";

	private int partid;

	private float time;

	private int weight;

	private List<Goods_goods.GoodData> mAttrs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	private void DeadAction(EntityBase entity)
	{
	}

	protected virtual void OnDeadAction(EntityBase deadentity, EntityPartBodyBase partbody)
	{
	}

	protected float GetAliveTime()
	{
		return 0f;
	}

	protected void SetAliveTime(float time)
	{
	}
}
