using System;
using UnityEngine;

public class BulletLineCtrl : MonoBehaviour
{
	private GameObject mBulletLineStart;

	private LineRenderer mBulletLining;

	private GameObject mBulletLineEnd;

	private ParticleSystem[] mStartP;

	private ParticleSystem[] mEndP;

	private BulletBase mBullet;

	private BulletBase mLastBullet;

	private bool bStart;

	private bool bOverDistance;

	public Action mOverDistanceEvent;

	private const float textureLengthScale = 3f;

	private const float textureScrollSpeed = 8f;

	private void Awake()
	{
	}

	public void Init(BulletBase bullet, BulletBase lastbullet)
	{
	}

	private void Update()
	{
	}

	private void UpdateEffect()
	{
	}

	private bool CheckOverDistance()
	{
		return false;
	}

	public bool IsOverDistance()
	{
		return false;
	}

	private void ParticleClear()
	{
	}

	public void Cache()
	{
	}
}
