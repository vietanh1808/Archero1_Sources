using UnityEngine;
using UnityEngine.UI;

public class CommonTipUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText contentText;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private ScrollRect scollRect;

	private CommonTipData data;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Click()
	{
	}

	private void Esc()
	{
	}

	private void ClickInfo()
	{
	}
}
