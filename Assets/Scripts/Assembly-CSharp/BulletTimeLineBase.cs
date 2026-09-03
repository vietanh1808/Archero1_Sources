using TableTool;
using UnityEngine;

public class BulletTimeLineBase : MonoBehaviour
{
	protected EntityTimeLineBase owner;

	protected Transform bulletTrans;

	private bool isStart;

	private float timer;

	private float maxTime;

	private Vector3 tarPos;

	private Vector3 startPos;

	private Vector3 speedvec;

	private float maxLenght;

	public Weapon_weapon weapondata { get; private set; }

	public int BulletId { get; private set; }

	public void Init(int id, EntityTimeLineBase pW, Weapon_weapon wpData)
	{
	}

	protected virtual void CreatModel()
	{
	}

	protected void SetModelScale()
	{
	}

	public void Rest()
	{
	}

	public void StartAttack()
	{
	}

	private void UpdateBullet(float dt)
	{
	}

	public void Dispose()
	{
	}

	private void OnDestroy()
	{
	}
}
