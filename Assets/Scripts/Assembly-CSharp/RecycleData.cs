public class RecycleData<T> where T : class
{
	protected T Data { get; set; }

	public virtual void Init()
	{
	}

	public virtual void SyncData(T data)
	{
	}

	public virtual void Clear()
	{
	}

	public virtual bool HaveData()
	{
		return false;
	}
}
public abstract class RecycleData<T1, T2> where T1 : class where T2 : class
{
	protected T1 Data1 { get; set; }

	protected T2 Data2 { get; set; }

	public virtual void SyncData(T1 data1, T2 data2)
	{
	}

	public virtual void Clear()
	{
	}

	public virtual bool HaveData()
	{
		return false;
	}
}
public abstract class RecycleData<T1, T2, T3> where T1 : class where T2 : class where T3 : class
{
	protected T1 Data1 { get; set; }

	protected T2 Data2 { get; set; }

	protected T3 Data3 { get; set; }

	public virtual void SyncData(T1 data1, T2 data2, T3 data3)
	{
	}

	public virtual void Clear()
	{
	}

	public virtual bool HaveData()
	{
		return false;
	}
}
