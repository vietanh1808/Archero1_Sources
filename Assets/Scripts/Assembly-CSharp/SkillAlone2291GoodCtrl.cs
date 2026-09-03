using System;
using UnityEngine;

public class SkillAlone2291GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private SkillAlone2291SubGood1Ctrl m_SubGood1Ctrl;

	[SerializeField]
	private SkillAlone2291SubGood2Ctrl m_SubGood2Ctrl;

	private GameObject hitEff;

	private GameObject injuredEff;

	private int maxCount;

	private Action OnHitMaxCount;

	public int ResistCount { get; set; }

	public void SetEntityParent(EntityBase entity)
	{
	}

	private void dealHit()
	{
	}

	public void SetMaxHitCount(int count, Action OnHitMax)
	{
	}
}
