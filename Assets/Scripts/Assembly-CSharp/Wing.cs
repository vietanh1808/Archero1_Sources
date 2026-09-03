using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour
{
	private EntityBase _entity;

	private int _id;

	private int _star;

	[SerializeField]
	private GameObject[] _inGameLeftEffects;

	[SerializeField]
	private GameObject[] _inGameRightEffects;

	[SerializeField]
	private GameObject[] _outGameLeftEffects;

	[SerializeField]
	private GameObject[] _outGameRightEffects;

	public void Init(EntityBase entity, int id, int star)
	{
	}

	public void Deinit()
	{
	}

	private void OnDropEnd()
	{
	}

	public void RefreshUI(int star)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ClearWingParticles(List<GameObject[]> list)
	{
	}

	private void OnRelicWuKongAIEnd()
	{
	}
}
