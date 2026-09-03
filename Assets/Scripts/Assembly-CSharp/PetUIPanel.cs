using System.Collections.Generic;
using PureMVC.Interfaces;

public class PetUIPanel : MediatorCtrlBase
{
	public PetSeat[] petSeats;

	public PetOneInfinity infinity;

	public ButtonCtrl closeBtn;

	public ButtonCtrl shopBtn;

	public ButtonCtrl upBtn;

	public ButtonCtrl tipsBtn;

	public HeroPropInfoCtrl atkCtrl;

	public HeroPropInfoCtrl hpCtrl;

	public DxxText shopBtnTex;

	public DxxText upBtnText;

	public DxxText outWarText;

	public DxxText helpWarText;

	private List<LocalSave.PetOne> dataArray;

	private SelfAttributeData mSelfAttrShow;

	public static int matchSeatIndex;

	private int startIndex;

	private bool isExitSelect;

	protected override void OnInit()
	{
	}

	private void ClosePanel()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshList(bool isfirst = false)
	{
	}

	public void InItArr(bool isfirst)
	{
	}

	private void UpdateChildCallBack(int index, PetCardOneCtrl one)
	{
	}

	private void UpWarPet(LocalSave.PetOne pet)
	{
	}

	private void HelpWarPet(LocalSave.PetOne pet)
	{
	}

	private PetSeat GetSeatByWarIndex(int warIndex)
	{
		return null;
	}

	public void ShowCanUpTips(int index)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void Update()
	{
	}
}
