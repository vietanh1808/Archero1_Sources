using TableTool;

public abstract class AIMoveBase : ActionBasic.ActionUIBase
{
	protected Operation_move Data;

	public string ClassName;

	public int ClassID;

	protected JoyData m_MoveData;

	public AIMoveBase(EntityBase entity)
	{
	}

	protected sealed override void OnInit()
	{
	}

	protected virtual void OnDizzy(bool value)
	{
	}

	protected override void OnEnd1()
	{
	}

	protected abstract void OnInitBase();

	public static ConditionBase GetConditionTime(int time)
	{
		return null;
	}

	public static ConditionBase GetConditionRandomTime(int min, int max)
	{
		return null;
	}

	protected override void OnForceEnd()
	{
	}
}
