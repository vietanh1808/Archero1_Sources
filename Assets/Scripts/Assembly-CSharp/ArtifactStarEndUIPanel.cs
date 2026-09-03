using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactStarEndUIPanel : MediatorCtrlBase
{
	public Image Image_Banner;

	public DxxText Text_Title;

	public ArtifactModelShow modelShow;

	public DxxText Text_Name;

	public ArtifactStarShowItem starItem;

	public RectTransform Content;

	public GameObject cpItem;

	public DxxText Text_Touch;

	private List<ArtifactAttrEndItem> attrList;

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

	public void show_effect(int rare)
	{
	}
}
