using UnityEngine;

public class WukongHpSlider : HpSlider
{
	[Header("变身悟空血条")]
	[SerializeField]
	private Transform mWukongHpFG;

	private EntityHero m_hero;

	private bool m_bReducingWukongHP;

	private float m_fReducesHP;

	public void UpdateWukongHp(long value, float percent)
	{
	}

	protected override void OnLateUpdate()
	{
	}
}
