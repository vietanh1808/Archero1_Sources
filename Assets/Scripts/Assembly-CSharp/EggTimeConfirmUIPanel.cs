using System;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class EggTimeConfirmUIPanel : MediatorCtrlBase
{
	public class EggTimeComfirmData
	{
		public int EquipID;

		public LocalSave.EggData EggData;

		public int Min;

		public int Max;

		public int Count;

		public Action OnUse;
	}

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public DxxText Text_UseCount;

	public PropOneEquip topItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Use;

	public ButtonCtrl Button_Reduce;

	public ButtonCtrl Button_Plus;

	public ButtonCtrl Button_ReduceMin;

	public ButtonCtrl Button_PlusMax;

	public DxxText Text_Use;

	public Slider Slider_Count;

	public DxxText text_SliderCount;

	public DxxText text_Preview;

	private EggTimeComfirmData _data;

	private int Total;

	private LocalSave.EquipOne eData;

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

	private void RefreshPreviewShow()
	{
	}

	private void OnUseBtnClick()
	{
	}

	public void OnValueChanged()
	{
	}

	private void OnChangeCountBtnClick(int count)
	{
	}

	private void OnBtnReduceMinClick()
	{
	}

	private void OnBtnPlusMaxClick()
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
