public class Act5thHuntingEntityData
{
	public Act5thHuntingEntityStatus Status { get; set; }

	public float AttackValue { get; set; }

	public float MoveSpeed { get; set; }

	public float HPMaxCount { get; set; }

	public float HPLeftCount { get; set; }

	public int ReboundCount { get; set; }

	public static T Create<T>() where T : Act5thHuntingEntityData, new()
	{
		return null;
	}

	protected void SetData(float attackValue, float moveSpeed, float hpMaxCount, int reboundCount)
	{
	}

	public void UpdateHpCount(float count)
	{
	}

	public void UpdateReboundCount(int count)
	{
	}

	public bool IsInStatus(Act5thHuntingEntityStatus status)
	{
		return false;
	}

	public void SetStatus(Act5thHuntingEntityStatus status)
	{
	}

	public void AddStatus(Act5thHuntingEntityStatus status)
	{
	}

	public void RemoveStatus(Act5thHuntingEntityStatus status)
	{
	}
}
