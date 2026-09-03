using DG.Tweening;
using UnityEngine;

public class AI1847_TD : AIDizzyBase
{
	private const int TD_ID = 1847;

	public const float deltaScalePerGrid = 0.32f;

	public const float deltaRadiusPerGrid = 1f;

	private int initMaxMonsterCount;

	private float initTimeInterval;

	private float initGrid;

	public float initMonsterAtkTime;

	private TD1847HitCtrl hitCtrl;

	private GameObject topEffect;

	private GameObject transportEffect;

	private float time;

	private Tween tween;

	private int curMonsterCount;

	public float timeInterval => 0f;

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
