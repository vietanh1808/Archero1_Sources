using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipAllAttUIPanel : MonoBehaviour
{
	public DxxText txtAtk;

	public DxxText txtHp;

	public DxxText txtDefense;

	public DxxText txtBaseAtt;

	public DxxText txtOtherAtt;

	public DxxText txtTitle;

	public SailingShipAttributeItem attributeItem;

	public SailingHideAttItem hideAttItem;

	public Transform attParent;

	public Transform hideAttParent;

	public ButtonCtrl btnClose;

	public RectTransform rectTips;

	public DxxText txtTips;

	public ButtonCtrl btnAttack;

	public ButtonCtrl btnHp;

	public ButtonCtrl btnDefense;

	public ButtonCtrl[] btnTabs;

	public GameObject[] tabUnselected;

	public GameObject[] tabSelected;

	public GameObject goAllAttPanel;

	public GameObject goHideAttPanel;

	public DxxText txtSelectedTab1;

	public DxxText txtUnselectedTab1;

	public DxxText txtSelectedTab2;

	public DxxText txtUnselectedTab2;

	public DxxText txtHideTitle;

	public ScrollRect scroll;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	private Dictionary<string, double> _crtAttMap;

	private int _tabIndex;

	public void Init()
	{
	}

	private void RefreshTxt()
	{
	}

	private void RefreshAtt()
	{
	}

	private void RefreshAttDesc()
	{
	}

	public void OnDescTipsShow(Transform trans, string des, bool isSpecial = false)
	{
	}

	private void Esc()
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	public void OnBtnTabClick(int tabIndex)
	{
	}
}
