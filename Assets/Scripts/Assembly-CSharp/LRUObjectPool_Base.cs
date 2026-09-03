public abstract class LRUObjectPool_Base
{
	public abstract void pushObject(int id, object o);

	public abstract void removeObject(int id, object o);

	public abstract object pullObject(int id);

	public abstract void Clear();

	public abstract void Check();

	public abstract void ClearNode(int id);

	public abstract void ReadyObject(int id, int readyCount);

	public abstract void PrintInfo();

	public abstract void SetSingleMaxCount(int value);
}
