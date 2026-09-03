using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PetStarUpEndUIPanel : MediatorCtrlBase
{
	public Image Image_Banner;

	public DxxText Text_Title;

	public RawImage petImg;

	private HeroShow heroShow;

	public DxxText Text_Name;

	public PetStarShowItem starItem;

	public PetAttrEndItem attackItem;

	public PetAttrEndItem hpItem;

	public PetAttrEndItem attrItem;

	public DxxText Text_Touch;

	private List<PetAttrEndItem> attrList;

	private LocalSave.PetOne petOne;

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

	public void OnButtonTouchScrren()
	{
	}

	public void show_effect(int rare)
	{
	}
}
