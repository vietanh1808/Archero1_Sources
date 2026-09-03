using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class BulletBeamBase : BulletBase
{
	protected bool isStarted;

	private string beamStartName;

	private string beamEndName;

	private string beamLineName;

	private const float lineWidth = 1.2f;

	private float originalwidth;

	protected int layerMask;

	private BeamVO beamVO;

	private ActionBasic actionBeam;

	protected SequencePool mPool;

	protected LineRenderer line;

	protected Transform mStart;

	protected Transform mEnd;

	private bool isAlive;

	protected float beamAliveTime;

	protected virtual float startwidth => 0f;

	protected virtual bool Follow => false;

	protected virtual bool FireImme => false;

	protected virtual bool RefreshByBeamImme => false;

	protected virtual float AppearTimePercent => 0f;

	protected virtual bool UseFixedAppearTime => false;

	protected virtual float FixedAppearTime => 0f;

	protected virtual bool CustomizeBeamVO => false;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnOverDistance()
	{
	}

	public BeamVO GetBeamVO()
	{
		return null;
	}

	public void SetAliveTime(float value)
	{
	}

	public void StartFire()
	{
	}

	protected virtual void OnAfterStartFire()
	{
	}

	private void resetLine()
	{
	}

	protected void showAnim()
	{
	}

	private void initStartEnd()
	{
	}

	private void initLineRenderer()
	{
	}

	public void refreshByBeamVO()
	{
	}

	protected virtual void initLayerMask()
	{
	}

	private Tweener playAnim(float start, float end, float duration)
	{
		return null;
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void BeamDir2BulletDir()
	{
	}

	public virtual Vector3 GetBeamDir()
	{
		return default;
	}
}
