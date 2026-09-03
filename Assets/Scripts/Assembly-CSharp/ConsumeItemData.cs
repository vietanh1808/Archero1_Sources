using System.Collections.Generic;

public class ConsumeItemData : RecycleData<ConsumeItemBaseData>
{
	public long StatTime => 0L;

	public long EndTime => 0L;

	public int OpenGameLevel => 0;

	public ushort BoxType => 0;

	public List<ConsumeTaskItemData> TaskData => null;

	public bool IsOpen => false;
}
