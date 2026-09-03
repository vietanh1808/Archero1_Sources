using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingGhostFleetShipItem : MonoBehaviour
{
	[SerializeField]
	private GameObject selectObj;

	[SerializeField]
	private Image shipBg;

	[SerializeField]
	private SailingShipOne shipItem;

	[SerializeField]
	private GameObject difficultObj;

	[SerializeField]
	private DxxText difficultNum;

	[SerializeField]
	private Image difficultIcon;

	[SerializeField]
	private DxxText powerNum;

	[SerializeField]
	private DxxText maxGetScore;

	[SerializeField]
	private SailingGhostFleetAttribute attribute;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private Image lockIcon;

	[SerializeField]
	private Image lockMaskIcon;

	[SerializeField]
	private DxxFitContentText lockTip;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private ButtonCtrl lockBtn;

	[SerializeField]
	private GameObject refreshParObj;

	[SerializeField]
	private ParticleSystem refreshPar;

	private SailingGhostFleetShipItemData data;

	private bool isSelect;

	private int index;

	private int selectIndex;

	private bool isInit;

	private SailingGhostFleetManager SailingGhostFleetManager => null;

	private SailingGhostFleetData SailingGhostFleetData => null;

	private void Init()
	{
	}

	public void Refresh(int index, int selectIndex, SailingGhostFleetShipItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshShipItem()
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshAttribute()
	{
	}

	private void RefreshStatus()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void ClickBtn()
	{
	}

	private void ClickLockBtn()
	{
	}

	public void PlayRefreshPar()
	{
	}

	public void SetClickBtnActive(bool isActive)
	{
	}
}
