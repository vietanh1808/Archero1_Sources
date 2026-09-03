using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipBaseUIPanel : MonoBehaviour, ICampUILifeCycle
{
	public SailingShipPartsTabItem PartItems;

	public DxxText atkCount;

	public DxxText hpCount;

	public DxxText defenseCount;

	public DxxText attTitleText;

	public DxxText upgradeBtnText;

	public DxxText unlockTxt;

	public DxxText powerAniTxt;

	public ButtonCtrl ChangeBtn;

	public ButtonCtrl attInfoBtn;

	public ButtonCtrl upgradeBtn;

	public DxxImage imgUpGrade;

	public SailingShipMaterialShow mShow;

	public SailingShipPartAttItem attributeItem;

	public RectTransform rectPartsParent;

	public RectTransform rectShipParent;

	public RectTransform rectPartAttParent;

	public RectTransform rectMapParent;

	public SailingShipPartInfoItem partItem;

	public SailingShipCrewRoomCtrl roomCtrl;

	public SailingCrewRoomUIPanel crewRoomUI;

	public SailingShipAllAttUIPanel allAttributePanel;

	public SailingShipOne shipOne;

	public Color powerUpColor;

	public Color powerDownColor;

	public RedNodeCtrl upgradeBtnNode;

	public ParticleSystem upgradeEffect;

	private LocalUnityObjctPool pool;

	private int selectPartID;

	private List<SailingShipPartsTabItem> crtTabs;

	private SailingShipOne _crtShip;

	private int _crtPower;

	private SailingShipPartData _sData => null;

	private SailingShipPartItemData crtPartData => null;

	private void Awake()
	{
	}

	public void OnOpen()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshShipAtt()
	{
	}

	public void PlayPowerAni()
	{
	}

	public void InItShipPartsTabItem()
	{
	}

	public void RefreshTabRedNode()
	{
	}

	public void OnPartsItemClick(int partID)
	{
	}

	public void RefreshChangeBtnStatus()
	{
	}

	public void OnUpgradeBtnClick()
	{
	}

	public void InitMap()
	{
	}

	public void RefreshRedNode()
	{
	}

	public void InitShip()
	{
	}

	public void RefreshPartsInfo()
	{
	}

	public void RefreshAttributes()
	{
	}

	public void RefreshUpgradeMaterials()
	{
	}

	public void OnPartSkinChanged(int partID)
	{
	}

	public void InitCrewRoom()
	{
	}

	public void OnCrewRoomClicked(int roomID)
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}
}
