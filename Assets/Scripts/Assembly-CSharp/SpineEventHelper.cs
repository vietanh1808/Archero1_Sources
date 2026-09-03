using System;
using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;

public class SpineEventHelper : MonoBehaviour
{
	[Serializable]
	public class SpineFrameKey
	{
		[SpineEvent(null, null, true, false, false)]
		public string key;

		public UnityEvent handler;
	}

	[SerializeField]
	private List<SpineFrameKey> handlers;

	private Dictionary<string, UnityEvent> keyFrameEventDict;

	public const string START_EVENT = "START_EVENT";

	public const string END_EVENT = "END_EVENT";

	private SkeletonGraphic skeletonAnimation;

	private void Start()
	{
	}

	private void Bind()
	{
	}

	public void AddCustomEventHandler(string key, UnityAction handler)
	{
	}

	public void RemoveCustomEventHandler(string key, UnityAction handler = null)
	{
	}

	public void AddStartEventHandler(UnityAction handler)
	{
	}

	public void RemoveStartEventHandler(UnityAction handler)
	{
	}

	public void AddEndEventHandler(UnityAction handler)
	{
	}

	public void RemoveEndEventHandler(UnityAction handler)
	{
	}

	private void HandleEvent(TrackEntry trackEntry, Spine.Event e)
	{
	}

	public void Clear()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetEventHandler(string key, UnityAction handler)
	{
	}
}
