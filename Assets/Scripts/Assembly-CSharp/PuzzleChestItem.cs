using Activity.Anniversary;
using UnityEngine;
using XLua;

public class PuzzleChestItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private RectTransform rtLight;

	[SerializeField]
	private RedNodeCtrl redNode;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private int id;

	[SerializeField]
	private GameObject goTick;

	[SerializeField]
	private Animation anim;

	private JigsawState state;

	private PuzzleChestItemData data;

	private static DelegateBridge __Hotfix0_get_PuzzleManager;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClick;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshContent;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleManager PuzzleManager => null;

	private void Awake()
	{
	}

	public void OnClick()
	{
	}

	public void Refresh(PuzzleChestItemData data)
	{
	}

	public void RefreshContent()
	{
	}
}
