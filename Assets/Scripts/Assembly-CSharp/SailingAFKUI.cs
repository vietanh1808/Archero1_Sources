using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingAFKUI : MonoBehaviour, ICampUILifeCycle
{
	public Image Image_Town;

	public Image Image_ButtonTown;

	public DxxText Town_Name;

	public DxxText Text_Auto;

	public DxxText Text_Exc;

	public DxxText Text_Time;

	public PropOneEquip propItem;

	public PropOneEquip propItemArrow;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public ButtonCtrl Button_Town;

	public ButtonCtrl Button_Factory;

	public ButtonCtrl Button_Exchange;

	public GameObject cpItem;

	public RectTransform RTF_Panel;

	public DxxText Text_Town;

	public DxxText Text_Factory;

	public ButtonCtrl Button_Info;

	[SerializeField]
	private ButtonCtrl skinBtn;

	[SerializeField]
	private DxxText skinBtnName;

	private int sdk_time;

	private int sdk_talent;

	private int sdk_arrow;

	public GameObject RedPoint_TownLevelUp;

	public GameObject RedPoint_RewardGet;

	public void Awake()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	private void RefreshText()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void initUI()
	{
	}

	private void onButtonTown()
	{
	}

	private void onButtonFactory()
	{
	}

	private void onButtonGet()
	{
	}

	private void freshTime()
	{
	}

	private void OnButtonExc()
	{
	}

	private void onButtonInfo()
	{
	}

	private void freshRedPoint()
	{
	}

	private void RefreshCampTownSkin()
	{
	}
}
