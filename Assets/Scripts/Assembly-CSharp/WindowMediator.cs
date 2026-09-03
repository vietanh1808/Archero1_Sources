using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public abstract class WindowMediator : Mediator
{
	public enum LayerType
	{
		eRoot = 0,
		eInGame = 1,
		eFront = 2,
		eFrontEvent = 3,
		eFront2 = 4,
		eFront3 = 5,
		eFrontMask = 6,
		eFrontNet = 7,
		eFrontForce = 8
	}

	public class WindowCacheData
	{
		public string name;

		public GameObject obj;

		public float lasttime;

		public string path;
	}

	public static Dictionary<string, WindowCacheData> mCacheUIPanel;

	public static Dictionary<string, FrontEventCtrl> mFrontEventList;

	public static Dictionary<string, Sequence> mSequences;

	public object mData;

	protected string UIPath;

	private GameObject _popupparent;

	private FrontEventCtrl mFrontEventCtrl;

	protected GameObject _MonoView;

	public sealed override IEnumerable<string> ListNotificationInterests => null;

	public virtual List<string> OnListNotificationInterests => null;

	public static void RemoveCache(string name)
	{
	}

	public GameObject GetUIPanel()
	{
		return null;
	}

	public WindowMediator(string path)
	{
	}

	private Transform GetParent()
	{
		return null;
	}

	private void UpdateCanvas(Canvas front)
	{
	}

	private Sequence GetSeq()
	{
		return null;
	}

	private void ClearSeq()
	{
	}

	private void OnRegisterAsync(bool have)
	{
	}

	private void DoRegisterOnce(GameObject res, bool have)
	{
	}

	public override void OnRegister()
	{
	}

	private void DoRegisterEvery()
	{
	}

	public sealed override void OnRemove()
	{
	}

	private void ClearCache()
	{
	}

	protected virtual void OnRemoveAfter()
	{
	}

	protected virtual void OnRegisterBefore()
	{
	}

	protected virtual void OnRegisterOnce()
	{
	}

	protected virtual void OnRegisterEvery()
	{
	}

	public sealed override void HandleNotification(INotification notification)
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}

	public virtual void OnShowWindow()
	{
	}

	protected abstract void OnLanguageChange();

	public void WindowShowUI(bool show)
	{
	}

	public virtual bool PreloadRes()
	{
		return false;
	}
}
