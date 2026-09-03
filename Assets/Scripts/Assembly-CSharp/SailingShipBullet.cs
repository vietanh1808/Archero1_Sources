using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipBullet : MonoBehaviour
{
	[SerializeField]
	private RectTransform bullet;

	[SerializeField]
	private float minScale;

	[SerializeField]
	private ParticleSystem hitSeaPar;

	[SerializeField]
	private Image bulletIcon;

	[SerializeField]
	private Transform bulletParParent;

	[SerializeField]
	private Canvas bulletCanvas;

	[SerializeField]
	private GameObject normalStatus;

	[SerializeField]
	private GameObject bossStatus;

	private const float HeightMinFactor = 0.015f;

	private const float HeightMaxFactor = 0.03f;

	private Vector2 startPoint;

	private Vector2 endPoint;

	private bool isHitFromDownToUp;

	private bool isHitSea;

	private SequencePool sequencePool;

	private Vector2 startPos;

	private Vector2 endPos;

	private float bulletFlyTime;

	private int skinID;

	private SailingShipBossAttackStyle bossAttackStyle;

	private bool IsBossStyle => false;

	public void StartBulletAni(int skinID, SailingShipBossAttackStyle bossAttackStyle, Vector2 startPoint, Vector2 endPoint, float bulletFlyTime, bool isHitFromDownToUp, bool isHitSea)
	{
	}

	private void StartAni()
	{
	}

	private void PlayHitPar()
	{
	}

	private Vector2 CalculateParabolaPeak(Vector2 A, Vector2 B, float heightFactor)
	{
		return default;
	}

	private void RefreshBullet()
	{
	}
}
