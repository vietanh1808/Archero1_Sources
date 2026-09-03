using System.Collections.Generic;
using UnityEngine;

public class Act5thHuntingEntityManager : CInstance<Act5thHuntingEntityManager>
{
	public const float AnimalOriginRadius = 60f;

	public const float ArrowOriginWidth = 29f;

	public const float ArrowOriginLength = 125f;

	private HashSet<IAct5thHuntingArrow> HuntingArrows { get; set; }

	private HashSet<IAct5thHuntingAnimal> HuntingAnimals { get; set; }

	private HashSet<IAct5thHuntingArrow> NeedClearHuntingArrows { get; set; }

	private HashSet<IAct5thHuntingAnimal> NeedClearHuntingAnimals { get; set; }

	private Transform HuntingEntityParent { get; set; }

	private RectTransform HuntingGameSceneRect { get; set; }

	private LocalUnityObjctPool EntityPool { get; set; }

	private Act5thHuntingGameStatus Status { get; set; }

	public float WallWidth => 0f;

	public float WallLength => 0f;

	public Vector2 WallCenter => default;

	private void InitStart()
	{
	}

	private void InitEntityPool()
	{
	}

	public void GameStart(Transform huntingEntityParent, RectTransform gameSceneRect)
	{
	}

	public void GameEnd()
	{
	}

	public Act5thHuntingArrow CreateArrow()
	{
		return null;
	}

	public Act5thHuntingAnimal CreateAnimal()
	{
		return null;
	}

	public void RemoveEntity(IAct5thHuntingEntity entity)
	{
	}

	public void RemoveEntityGameObject(IAct5thHuntingEntity entity)
	{
	}

	public void ClearAnimalData()
	{
	}

	public HashSet<IAct5thHuntingArrow> GetAllArrow()
	{
		return null;
	}

	public HashSet<IAct5thHuntingAnimal> GetAllAnimal()
	{
		return null;
	}

	public HashSet<IAct5thHuntingArrow> GetNeedClearAllArrow()
	{
		return null;
	}

	public HashSet<IAct5thHuntingAnimal> GetNeedClearAllAnimal()
	{
		return null;
	}

	public void ClearEntity()
	{
	}

	public void ClearNeedClearEntity()
	{
	}

	public bool IsInStatus(Act5thHuntingGameStatus status)
	{
		return false;
	}

	public void SetStatus(Act5thHuntingGameStatus status)
	{
	}

	public void AddStatus(Act5thHuntingGameStatus status)
	{
	}

	public void RemoveStatus(Act5thHuntingGameStatus status)
	{
	}
}
