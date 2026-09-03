using UnityEngine;
using UnityEngine.UI;

public class GuildTabItem : GuildUIChildCtlBase
{
	public string langKey;

	public GameObject focusObj;

	public Text normalName;

	public Text focusName;

	public Button button;

	public GameObject RedPoint;

	public override void OnLanguageChange()
	{
	}

	public void SetFocus(bool pFocus)
	{
	}

	public void showRedPoint(bool show)
	{
	}
}
