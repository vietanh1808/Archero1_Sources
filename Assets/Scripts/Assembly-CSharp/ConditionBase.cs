public abstract class ConditionBase
{
	protected float starttime;

	public ConditionBase()
	{
	}

	protected abstract void Init();

	public virtual bool IsEnd()
	{
		return false;
	}

	public void ResetStartTime(float value)
	{
	}
}
