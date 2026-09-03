using System.Collections.Generic;
using UnityEngine;

public class Bullet1148 : BulletBase
{
	private Animation ani;

	private float m_fRange;

	private int m_nDebuffId;

	public GameObject effect;

	public ParticleSystem ring;

	protected override void OnInit()
	{
	}

	protected virtual List<EntityBase> GetEnemies()
	{
		return null;
	}
}
