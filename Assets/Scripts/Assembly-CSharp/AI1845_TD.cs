using DG.Tweening;
using UnityEngine;

public class AI1845_TD : AIDizzyBase
{
	private const int TD_ID = 1845;

	public const float deltaScalePerGrid = 0.5f;

	public const float deltaRadiusPerGrid = 1.25f;

	private int initMaxMonsterCount;

	private float initTimeInterval;

	private float initGrid;

	public float initMonsterAtkTime;

	private TD1845HitCtrl hitCtrl;

	private GameObject fireEffect;

	private GameObject circleEffect;

	private float time;

	private Tween tween;

	private Tween expandTween;

	private int curMonsterCount;

	public float timeInterval => 0f;

	private float startRadius => 0f;

	private float maxRadius => 0f;

	private float particleTime => 0f;

	private int MaxMonsterCount => 0;

	private float GetCurGrid()
	{
		return 0f;
	}

	protected override void OnInitOnce()
	{
	}

	private void initParameters()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	public bool ReachMaxMonCount()
	{
		return false;
	}

	public void UpdateMonCount(int delta)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void activateEffect()
	{
	}

	private void createHitCtrl()
	{
	}

	private GameObject createEffect(string path)
	{
		return null;
	}
}
