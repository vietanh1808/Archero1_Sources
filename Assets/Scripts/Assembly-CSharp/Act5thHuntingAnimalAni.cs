using PureMVC.Interfaces;
using Spine;
using Spine.Unity;
using UnityEngine;

public class Act5thHuntingAnimalAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private SkeletonGraphic urgencyStatusAni;

	[SerializeField]
	private SkeletonGraphic beAttackAni;

	private Spine.AnimationState UrgencyState => null;

	private Spine.AnimationState BeAttackState => null;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void RefreshAllAni()
	{
	}

	private void StopAllAni()
	{
	}

	public void SetSizeScale(float scale)
	{
	}

	public void PlayUrgencyAni()
	{
	}

	public void PlayBeAttackAni()
	{
	}

	public void StopUrgencyAni()
	{
	}

	public void StopBeAttackAni()
	{
	}

	public void Recycle()
	{
	}
}
