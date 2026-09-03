using System.Collections.Generic;
using UnityEngine;

public class ChatPanelText : MonoBehaviour
{
	public RectTransform contentRTF;

	public GameObject cpInput;

	private bool isInit;

	private List<ChatInputText> textList;

	public RectTransform InputPanelRect;

	public RectTransform QuickPanelRect;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Quick;

	public ButtonCtrl Button_Send;

	public DxxInput mInput;

	private string endInputText;

	private const int LimitInputCount = 100;

	private bool isOpenInputMode;

	private float QuickHeight;

	private float KeyBoardHeight;

	private float upTimer;

	private float scale;

	private float scalex;

	private float scaley;

	private float design;

	private float real;

	public void Awake()
	{
	}

	public void showPanel()
	{
	}

	public void showModeQuick()
	{
	}

	public void showModeInput()
	{
	}

	public void hidePanel()
	{
	}

	private void init()
	{
	}

	public void onButtonCancel()
	{
	}

	public void onLanguageChanged()
	{
	}

	public void onButtonBack()
	{
	}

	public void onButtonQuick()
	{
	}

	public void onButtonSend()
	{
	}

	private void setInputWidth(int width)
	{
	}

	private void Update()
	{
	}

	public float ScreenToGameValue(float screen)
	{
		return 0f;
	}
}
