using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityInfoPopUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private VerticalLayoutGroup layoutGroup;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnBg;

	private List<string> keys;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Escape()
	{
	}
}
