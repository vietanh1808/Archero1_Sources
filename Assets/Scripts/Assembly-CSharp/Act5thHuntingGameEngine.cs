using System.Collections.Generic;

public class Act5thHuntingGameEngine : CInstance<Act5thHuntingGameEngine>
{
	private Act5thHuntingEntityManager HuntingEntityManager => null;

	private HashSet<IAct5thHuntingArrow> AllArrow => null;

	private HashSet<IAct5thHuntingAnimal> AllAnimal => null;

	private HashSet<IAct5thHuntingArrow> NeedClearAllArrow => null;

	private HashSet<IAct5thHuntingAnimal> NeedClearAllAnimal => null;

	public void Start()
	{
	}

	public void End()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void ClearSystem()
	{
	}

	private void MoveSystem(float deltaTime)
	{
	}
}
