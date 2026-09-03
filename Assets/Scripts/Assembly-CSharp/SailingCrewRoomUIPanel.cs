using System;
using System.Collections.Generic;
using UnityEngine;

public class SailingCrewRoomUIPanel : MonoBehaviour
{
	public Transform crewParent;

	public Transform petParent;

	public Transform crewAttParent;

	public SailingShipCrewItem crewItem;

	public SailingShipPetItem petItemShow;

	public SailingShipPetItem petItem;

	public DxxFitContentText crewAttItem;

	public DxxText titleText;

	public DxxText attTitleText;

	public DxxText changeBtnText;

	public DxxText descText;

	public DxxText powerText;

	public DxxText seasonText;

	public DxxText noPetText;

	public ButtonCtrl seasonBtn;

	public ButtonCtrl changeBtn;

	public ButtonCtrl closeBtn;

	public ButtonCtrl tabHeroBtn;

	public ButtonCtrl tabPetBtn;

	public GameObject tabHeroSelected;

	public GameObject tabPetSelected;

	public GameObject goPower;

	private LocalUnityObjctPool pool;

	private bool _isInit;

	private int selectCrewID;

	private int selectPetID;

	private bool _isHeroTab;

	private bool isInSeason;

	private List<SailingShipCrewItem> _crtCrewList;

	private List<SailingShipPetItem> _crtPetList;

	private Action _onCrewGoCallBack;

	private SailingShipCrewRoomItemData _crtRoomData;

	public void Init(int selectRoomID, Action onCrewGoCallback)
	{
	}

	public void Refresh()
	{
	}

	private void SwitchTab(bool isHero)
	{
	}

	private void RefreshTabView()
	{
	}

	private void InitCrewList()
	{
	}

	public void RefreshCrew(int crewID)
	{
	}

	private void _RefreshCrew(int crewID)
	{
	}

	public void RefreshCrewAtt()
	{
	}

	private void InitPetList()
	{
	}

	public void RefreshPet(int petID)
	{
	}

	private void _RefreshPet(int petID)
	{
	}

	public void RefreshPetAtt()
	{
	}

	private void RefreshBottomArea()
	{
	}

	public void OnSeasonBtnClicked()
	{
	}

	private void OnChangeBtnClicked()
	{
	}

	private void OnConfirmHero()
	{
	}

	private void OnConfirmPet()
	{
	}

	private void Esc()
	{
	}

	private void OnCloseBtnClicked()
	{
	}
}
