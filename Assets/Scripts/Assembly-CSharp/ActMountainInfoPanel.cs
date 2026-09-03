using UnityEngine;
using UnityEngine.UI;

public class ActMountainInfoPanel : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public ButtonCtrl Button_Close;

	public RectTransform Container;

	private ScrollRect scrollRect;

	public void OnInit()
	{
	}

	public void OnOpen(CommonInfoUIPanel.InsData mData)
	{
	}

	private void android_escape()
	{
	}

	public void OnClose()
	{
	}
}
