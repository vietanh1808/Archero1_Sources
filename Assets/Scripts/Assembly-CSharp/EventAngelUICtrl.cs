using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EventAngelUICtrl : MediatorCtrlBase
{
	private struct GetData
	{
		public int eventID;

		public int getid;

		public int formid;
	}

	public DxxText texttitle;

	public DxxText texttitle2;

	public ButtonCtrl buttonok1;

	public ButtonCtrl buttonok2;

	public List<Text> text_content;

	public List<Image> image;

	[SerializeField]
	private Image leftBgImg;

	private const int ChooseCount = 2;

	private new GetData mData;

	private int mRecoverHPId;

	private bool canAddMore;

	protected virtual WindowID WindowId => WindowID.WindowID_Invaild;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void OnEscape()
	{
	}

	protected virtual void InitSkill()
	{
	}

	private void OnClickOK1()
	{
	}

	private void OnClickOK2()
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
