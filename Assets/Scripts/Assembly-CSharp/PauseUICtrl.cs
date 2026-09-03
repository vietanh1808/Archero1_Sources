using UnityEngine;
using UnityEngine.UI;

public class PauseUICtrl : PauseUIBaseCtrl
{
	public ButtonCtrl Button_ExpLimit;

	public Text Text_ExpLimit;

	public DxxImage Image_ExpLimit;

	public GameObject AttributesParent;

	public UILineCtrlOne mLineOneCtrl;

	public DxxText[] mAttrNames;

	public DxxText[] mAttrValues;

	private string[] mAttrLanKeys;

	protected override void OnInit()
	{
	}

	private void RefreshExpLimitBtn()
	{
	}

	protected override void OnOpen()
	{
	}

	private string ParseTime(long seconds)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
