using DG.Tweening;

public class WeaponMeleeHammer : WeaponHammerBase
{
	private const int TOTAL_FRAMES = 24;

	private Sequence seq;

	private float animTime;

	public const float INIT_SCALE = 1f;

	protected ActionBasic controller;

	protected Tweener maxScaleTweener;

	protected Tweener minScaleTweener;

	private const float INIT_SCALE_FRAME = 8f;

	private const float MAX_SCALE_FRAME = 10f;

	private float REVERSE_INIT_SCALE_FRAME;

	private float REVERSE_MAX_SCALE_FRAME;

	private float MAX_SCALE => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void onAtkEnd()
	{
	}

	private void onAtk()
	{
	}

	public void onAttackPreStart()
	{
	}

	public void KillTweeners()
	{
	}

	public void ClearWeaponScaleAction()
	{
	}
}
