using DG.Tweening;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class BreakEndOneCtrl : MonoBehaviour
{
	public DxxText Text_Quality;

	public DxxText Text_Name;

	public PropOneEquip equipone;

	public GameObject effect_rotate;

	public CanvasGroup mCanvasGroup;

	private int quality;

	private GameObject m_effect;

	private PropType type;

	public void Init(Drop_DropModel.DropData data)
	{
	}

	public virtual void ShowEffectRotate()
	{
	}

	private float get_start_scale()
	{
		return 0f;
	}

	public void update_start_scale()
	{
	}

	public float GetAnimationTime()
	{
		return 0f;
	}

	public Sequence GetAnimation(SequencePool pool, Vector3 endpos)
	{
		return null;
	}

	protected virtual void GetEffect()
	{
	}
}
