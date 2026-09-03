using UnityEngine.UI;

public class CampMatExchangeUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Btn_Exc;

	public ButtonCtrl Btn_Reduce;

	public ButtonCtrl Btn_Plus;

	public ButtonCtrl Btn_Close;

	public ButtonCtrl Btn_Info;

	public MatItem[] items;

	public Slider Slider_Count;

	public DxxText Text_Count;

	public DxxText Text_ExcCount;

	public DxxText Text_Title;

	public DxxText Text_LeftTime;

	public DxxText Text_Exchange;

	private int crtIndex;

	private float limitCount;

	protected override void OnInit()
	{
	}

	private void OnPlusOrReduceBtnClick(int index)
	{
	}

	private void OnMatBtnClick(int index)
	{
	}

	private void OnInfoBtnClick()
	{
	}

	private void OnExcBtnClick()
	{
	}

	private void RefreshUI()
	{
	}

	protected override void OnOpen()
	{
	}

	public void OnSliderValueChange()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
