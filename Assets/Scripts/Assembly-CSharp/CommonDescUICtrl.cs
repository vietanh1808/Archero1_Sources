using UnityEngine;

public class CommonDescUICtrl : MediatorCtrlBase
{
	public DxxText Text_Desc;

	public DxxText Text_Title;

	public ButtonCtrl ButtonClose;

	public RectTransform backGround;

	private string[] descKey;

	private const float BACKINTERVAL = 232f;

	private float contentY;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Update()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void UpdateBack()
	{
	}
}
