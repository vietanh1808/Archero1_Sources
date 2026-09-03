using UnityEngine;
using UnityEngine.UI;
using XLua;

public class IssueRedEnvelopPanel : MonoBehaviour
{
	public DxxText titleTex;

	public DxxText nameTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public Image redIcon;

	public DxxText subTitleTex;

	public ButtonCtrl reduceBtn;

	public ButtonCtrl addBtn;

	public Slider slider;

	public DxxText numTex;

	public DxxText descTex;

	public ButtonCtrl sureBtn;

	private ActRedEnvelopeMgr.RedEnvelopeItem mData;

	private int minCount;

	private int maxCount;

	private int curCount;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Reduce;

	private static DelegateBridge __Hotfix0_Add;

	private static DelegateBridge __Hotfix0_OnValueChanged;

	private static DelegateBridge __Hotfix0_ClickSureBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Open(ActRedEnvelopeMgr.RedEnvelopeItem data)
	{
	}

	public void Close()
	{
	}

	private void Reduce()
	{
	}

	private void Add()
	{
	}

	public void OnValueChanged(float count)
	{
	}

	private void ClickSureBtn()
	{
	}
}
