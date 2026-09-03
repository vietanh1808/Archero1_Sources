using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

[Serializable]
public abstract class LocalSaveBase
{
	[JsonIgnore]
	private bool Writeable;

	[JsonIgnore]
	private object locker;

	[JsonIgnore]
	public bool isDirty { get; private set; }

	protected virtual string filename { get; }

	protected void SetDirty()
	{
	}

	private void SetClean()
	{
	}

	public void Refresh()
	{
	}

	protected abstract void OnRefresh();

	protected virtual string serializeObject()
	{
		return null;
	}

	protected object GetLocker()
	{
		return null;
	}

	public virtual void SaveData()
	{
	}

	public virtual LocalSaveBase Clone()
	{
		return null;
	}

	public virtual void Clone(LocalSaveBase source)
	{
	}

	[OnDeserialized]
	private void Deserialized(StreamingContext context)
	{
	}

	protected virtual void OnDeserialized(StreamingContext context)
	{
	}
}
