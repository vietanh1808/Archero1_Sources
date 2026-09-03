using UnityEngine;
using UnityEngine.UI;

public class MsgItemChat : MsgItemBaseWithLRHeadItem
{
	public RectTransform PanelRTF;

	public RectTransform MidRTF;

	public Image BG;

	public DxxText Text_Time;

	public DxxText Text_Content;

	public DxxText Text_LName;

	public DxxText Text_RName;

	public DxxText Text_LGrade;

	public DxxText Text_RGrade;

	public ButtonCtrl Button_Translate;

	public GameObject Translated;

	public GameObject TransLoading;

	public GameObject LTop;

	public GameObject Wait;

	public ButtonCtrl Button_Yellow;

	public ButtonCtrl Button_Red;

	private ChatMsgDataChat data;

	public RectTransform reportPointRect;

	protected new void Awake()
	{
	}

	protected override void OnInit(ChatMsgDataBase d)
	{
	}

	public void onButtonTranslate()
	{
	}

	public void onButtonLongPress()
	{
	}

	private void setMineState(int state)
	{
	}

	private void onButtonYellow()
	{
	}

	private void onButtonRed()
	{
	}
}
