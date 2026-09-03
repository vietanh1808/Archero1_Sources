using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactGetUIPanel : MediatorCtrlBase
{
	public Image Image_Banner;

	public DxxText Text_Title;

	public DxxText Text_Info;

	public ArtifactModelShow modelShow;

	public DxxText Text_Desc;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	private LocalSave.ArtifactOne artiOne;

	private Dictionary<int, GameObject> mChangeEffects;

	public Transform effectParent;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void Esc()
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

	public void OnButtonTouchScrren()
	{
	}

	private void onButtonOK()
	{
	}

	public void show_effect(int rare)
	{
	}
}
