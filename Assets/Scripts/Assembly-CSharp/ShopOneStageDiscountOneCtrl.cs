using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopOneStageDiscountOneCtrl : MonoBehaviour
{
	public bool IsInShopDiscountPanel;

	public DxxText Text_Count;

	public Image Image_Icon;

	public DxxText Text_Content;

	public Image Image_GiftBack;

	public Image Image_GiftType;

	public Image imgFrame;

	public GameObject Gold_Effect;

	[SerializeField]
	private ButtonCtrl btn;

	public Image Circle;

	public DxxText Text_Level;

	public GameObject Type20;

	public DxxText Text_Time;

	private Drop_DropModel.DropData mData;

	private int colorIndex;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnLanguageUpdate;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Init(Drop_DropModel.DropData data, int colorIndex, bool isInShopDiscountPanel = false)
	{
	}

	public void OnLanguageUpdate()
	{
	}
}
