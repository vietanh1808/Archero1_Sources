using System.Collections.Generic;

public class BehaviorManager
{
	private static BehaviorManager _instance;

	private Dictionary<int, IBehavior> behaviorDic;

	public static BehaviorManager Instance => null;

	public void ExcuteBehavior(BehaviorCommand cmd, EntityBase entity)
	{
	}

	private IBehavior Get(int id)
	{
		return null;
	}

	private IBehavior InitBehavior(int id)
	{
		return null;
	}
}
