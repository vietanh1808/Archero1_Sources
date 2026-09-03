using System;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PlinkoCylinderItem : MonoBehaviour
{
	private float _radius;

	private bool preSpecial;

	public SkeletonGraphic aniItem;

	private Action showReward;

	private Action aniCompleteAction;

	private bool isInit;

	public Vector3 LocalPosition => default;

	public float Radius => 0f;

	public PlinkoCylinderData Data { get; private set; }

	public void SetData(PlinkoCylinderData data)
	{
	}

	public void setSpecialItem()
	{
	}

	public void PlayEffect_Normal()
	{
	}

	public void PlayEffect_Hit()
	{
	}

	public void PlayEffect_Switch()
	{
	}

	public void Awake()
	{
	}

	private void Init()
	{
	}

	public void Play(int aniId)
	{
	}

	private void Complete(TrackEntry trackEntry)
	{
	}

	private void SpineEvent(TrackEntry trackEntry, Spine.Event e)
	{
	}
}
