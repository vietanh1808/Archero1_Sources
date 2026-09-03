using UnityEngine;

public class AI5114_Laser : AIMoveBase
{
	private EntityBase target;

	private float redshowtime;

	private float delaytime;

	private float updatetime;

	private RedLineCtrl[] mLineCtrl;

	private GameObject effect;

	private bool bCreateBullet;

	private float m_fAnglePerSecond;

	private int weaponId;

	public AI5114_Laser(EntityBase entity, float redshowtime, float delaytime)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void EffectCache()
	{
	}

	private void LineCache()
	{
	}

	protected override void OnEnd()
	{
	}
}
