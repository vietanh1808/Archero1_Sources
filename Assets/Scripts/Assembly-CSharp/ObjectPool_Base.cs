public abstract class ObjectPool_Base
{
	protected int m_MaxCount;

	public ObjectPool_Base(int maxCount)
	{
	}

	public abstract void Clear();

	public abstract void PushObject(object obj);

	public abstract object PullObject();
}
