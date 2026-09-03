using UnityEngine;

public class SailingShipPlayerInfoUIPanel : MediatorCtrlBase
{
	public DxxText txtTitle;

	public DxxText txtAtk;

	public DxxText txtHp;

	public DxxText txtDefense;

	public DxxText txtPower;

	public ButtonCtrl btnClose;

	public RectTransform partParent;

	public SailingShipPartInfoOne partOne;

	public SailingShipOne shipOne;

	public SailingShipCrewRoomCtrl crewRoomCtrl;

	public SailingPlayerHeadPartInfo headPartInfo;

	private LocalUnityObjctPool _pool;

	private SailingShipPartData _crtShipData;

	private SailingShipCrewRoomData _crtCrewRoomData;

	private SailingPlayerInfoData _crtPlayerData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void InitInfo()
	{
	}

	public void SetData()
	{
	}

	public void InitPart()
	{
	}

	public void RefreshBaseAttTxt()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void Esc()
	{
	}

	protected override void OnClose()
	{
	}
}
