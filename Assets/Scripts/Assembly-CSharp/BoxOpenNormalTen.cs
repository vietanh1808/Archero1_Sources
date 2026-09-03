using UnityEngine;
using UnityEngine.UI;

public class BoxOpenNormalTen : MonoBehaviour
{
	public Image Image_Icon;

	public ButtonCtrl Button_Ten;

	public DxxText Text_KeyNum;

	public GoldTextCtrl mGoldOld;

	public GoldTextCtrl mGoldNow;

	public DxxText Text_RetryNotFree;

	public DxxText Text_Price;

	public GameObject Go_Key;

	public GameObject Go_Diamond;

	public GameObject Go_GoldNormal;

	public BoxOpenUIStyle style;

	private int openNum;

	private int openDiamond;

	private BoxOpenSingleProxy.Transfer oneTransfer;

	private BoxOpenProxy.Transfer tenTransfer;

	private bool isTenByDiamond;

	private float retry_y;

	private float now_y;

	private float old_y;

	private void Awake()
	{
	}

	public void init(BoxOpenSingleProxy.Transfer onet, bool isByDiamond = false, int diamond = 0)
	{
	}

	private void InitGoldText()
	{
	}

	private void InitLargeText(int old, int now)
	{
	}

	private void initNormal()
	{
	}

	private void initLarge()
	{
	}

	private void TenNormal()
	{
	}

	private void TenLarge()
	{
	}

	private void initMix()
	{
	}

	private void TenMix()
	{
	}

	private void initDragon()
	{
	}

	private void TenDragon()
	{
	}

	private void initRelics()
	{
	}

	private void TenRelics()
	{
	}

	private void initEquipS()
	{
	}

	private void TenEquipS()
	{
	}

	private void initManor()
	{
	}

	private void TenManor()
	{
	}

	private void initPet()
	{
	}

	private void TenPet()
	{
	}

	private void initImprint()
	{
	}

	private void TenImprint()
	{
	}
}
