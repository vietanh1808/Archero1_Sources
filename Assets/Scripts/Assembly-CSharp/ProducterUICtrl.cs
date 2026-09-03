using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;

public class ProducterUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ScrollRectBase mScroll;

	public List<ProducterOneCtrl> mList;

	private static List<string> mProducters;

	private bool movedown;

	private bool bMove;

	private float verticalPrev;

	private float verticalCurrent;

	private SequencePool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateList()
	{
	}

	private void UpdateChildCallBack(int index, ProducterOneCtrl one)
	{
	}

	private void Update()
	{
	}

	private void delay_move()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
