using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingMainCurrencyUI : MonoBehaviour
{
	public GameObject MilitaryObj;

	public Image Image_Military;

	public DxxText Text_Military;

	public GameObject PowerObj;

	public DxxText Text_Power;

	public GameObject ProrIdA;

	public DxxText Text_PropIdA;

	public GameObject PropIdB;

	public DxxText Text_PropIdB;

	public GameObject KeyObj;

	public GameObject DiamondObj;

	[SerializeField]
	private ButtonCtrl StaminaClickAreaBtn;

	[SerializeField]
	private Image _bg;

	public ButtonCtrl Button_Diamond;

	[SerializeField]
	private ButtonCtrl _btnMilitaryRank;

	public DxxText Text_Diamond;

	public ProgressTextCtrl mProgressCtrl;

	private void Awake()
	{
	}

	private void OnClickStaminaArea()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void UpdateGold()
	{
	}

	private void UpdateDiamond()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void showItems(int tab)
	{
	}

	public void SwitchPage(int page)
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public Vector3 GetPowerPosition()
	{
		return default;
	}
}
