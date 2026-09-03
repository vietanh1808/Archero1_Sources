using System;
using UnityEngine;
using UnityEngine.Events;

public class WindowButtonCtrl : ButtonCtrl
{
	[Serializable]
	public class PreloadEvent : UnityEvent<Action>
	{
	}

	public enum MaskType
	{
		None = 0,
		Normal = 1,
		NetDoing = 2
	}

	[SerializeField]
	private WindowID _windowID;

	[SerializeField]
	private PreloadEvent _onPreload;

	[Header("OnClick时是否等待OnPreload完成")]
	[SerializeField]
	private bool _showLoading;

	[SerializeField]
	private MaskType _maskType;

	private bool m_bPreloadEndFlag;

	private bool m_bClickFlag;

	private Coroutine m_Coroutine;

	protected override void OnDownVirtual()
	{
	}

	protected override void OnClick()
	{
	}

	public void SetWindowID(WindowID wID)
	{
	}

	private void DoClick()
	{
	}

	private void OnPreloadEnd()
	{
	}

	private void ShowMask(bool show)
	{
	}

	protected override bool CheckOnClick()
	{
		return false;
	}
}
