using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Rendering;

public class PVESoulUI : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText Text_Count;

	public DxxText Text_Time2;

	public ButtonCtrl Button_Quick;

	public ButtonCtrl Button_Collect;

	public DxxText Text_Quick;

	public DxxText Text_Collect;

	public GameObject Water;

	public GameObject Panel;

	public RectTransform Rect_Panel;

	public DxxText Text_Tips;

	public GameObject RedPoint;

	public DxxText txtVipTips;

	public ButtonCtrl btnVipTips;

	private int _crtVipCount;

	private int hp;

	private int mp;

	private float waterMin;

	private float waterMax;

	[SerializeField]
	private SortingGroup sgroup1;

	[SerializeField]
	private SortingGroup sgroup2;

	public void init()
	{
	}

	public void Enter()
	{
	}

	private void show()
	{
	}

	public void onButtonQuick()
	{
	}

	public void onButtonCollect()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void onLanguaged()
	{
	}

	public void freshUI()
	{
	}

	private void RefreshVipInfo()
	{
	}

	private void OnVipBtnTipsClicked()
	{
	}
}
