using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2164GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private GameObject _bomb;

	private EntityBase _entity;

	private ActionBasic _action;

	public void Init(EntityBase entity, float radius, float hitRatio, float distance, List<int> debuffs)
	{
	}

	public void DeInit()
	{
	}
}
