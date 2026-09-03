using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopItemDiamondBoxBase : MonoBehaviour
{
	public DxxText Text_Content;

	public DxxText Text_Title;

	public DxxText Text_BoxContent;

	public Image Image_BG;

	public ButtonCtrl Button_Get;

	public GoldTextCtrl mGoldCtrl;

	public DxxText Text_Free;

	public RedNodeCtrl mRedCtrl;

	public GameObject FreeParent;

	public GameObject NotFreeParent;

	public CountDownCtrl mCountDownCtrl;

	public GameObject extraparent;

	public DxxText Text_Extra;

	public DxxText Text_Hint;

	public GameObject GroupBtn2;

	public ButtonCtrl FreeBtn2;

	public ButtonCtrl PaidBtn2;

	public DxxText Text_Extra2;

	public RedNodeCtrl mRedCtrl2;

	public GameObject GroupBtn3;

	public ButtonCtrl FreeBtn3;

	public DxxText Text_Free3;

	public ButtonCtrl PaidBtn3;

	public DxxText Text_Extra3;

	public RedNodeCtrl mRedCtrl3;

	protected bool bFreeShow;

	protected bool bBothShow;

	protected long mStartTime;

	protected int PerTime;

	protected long currenttime;

	protected int count;

	protected long last;

	protected float Text_FreeX;

	protected BoxOpenSingleProxy.Transfer mTransfer;

	protected LocalSave.TimeBoxType mBoxType;

	protected int mIndex;

	private bool bOpen;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_set_red;

	private static DelegateBridge __Hotfix0_update_red;

	private static DelegateBridge __Hotfix0_FreeShow;

	private static DelegateBridge __Hotfix0_CountDownShow;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_ForceUpdate;

	private static DelegateBridge __Hotfix0_UpdateBox;

	private static DelegateBridge __Hotfix0_Deinit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_LanguageChange;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickButton;

	private static DelegateBridge __Hotfix0_CheckCanOpen;

	private static DelegateBridge __Hotfix0_OnClickButton;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_RefreshBoxStateByRelics;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void Init(int index)
	{
	}

	protected virtual void OnInit()
	{
	}

	public virtual void UpdateUI()
	{
	}

	protected void set_red(int count)
	{
	}

	public void update_red()
	{
	}

	protected void FreeShow(bool value)
	{
	}

	protected void CountDownShow(bool value)
	{
	}

	private void Update()
	{
	}

	private void ForceUpdate()
	{
	}

	protected void UpdateBox()
	{
	}

	public void Deinit()
	{
	}

	protected virtual void OnDeinit()
	{
	}

	public void LanguageChange()
	{
	}

	protected virtual void OnLanguageChange()
	{
	}

	public void ClickButton()
	{
	}

	protected bool CheckCanOpen(int type, int price)
	{
		return false;
	}

	protected virtual void OnClickButton()
	{
	}

	public void UpdateNet()
	{
	}

	public virtual void RefreshBoxStateByRelics()
	{
	}
}
