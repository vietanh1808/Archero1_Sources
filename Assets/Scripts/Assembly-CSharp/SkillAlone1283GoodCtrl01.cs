using UnityEngine;

public class SkillAlone1283GoodCtrl01 : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject child_1;

	[SerializeField]
	private GameObject child_2;

	[SerializeField]
	private GameObject child_3;

	private float m_nLevel1;

	private float m_nLevel2;

	private float m_nLevel3;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private void OnSickleCntChanged(long cnt)
	{
	}
}
