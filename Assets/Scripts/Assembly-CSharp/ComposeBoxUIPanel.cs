using PureMVC.Interfaces;
using TableTool;
using UnityEngine.UI;

public class ComposeBoxUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText text_UseCount;

	public DxxText Text_Desc;

	public DxxText Text_Count;

	public PropOneEquip topItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Use;

	public ButtonCtrl Button_Reduce;

	public ButtonCtrl Button_Plus;

	public DxxText Text_Use;

	public Slider Slider_Count;

	public DxxText text_SliderCount;

	private int boxId;

	private int Total;

	private Box_ComposeBox boxData;

	private int crtCount;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	public void OnValueChanged()
	{
	}

	private void OnUseBtnClick()
	{
	}

	private void OnChangeCountBtnClick(int count)
	{
	}

	protected override void OnClose()
	{
	}

	private void onButtonClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
