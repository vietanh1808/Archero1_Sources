using UnityEngine;

public class EquipDownEndUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private TapToCloseCtrl closeCtrl;

	[SerializeField]
	private EquipOneCtrl resetItem;

	[SerializeField]
	private GameObject cpItem;

	[SerializeField]
	private ButtonCtrl btnScreen;

	[SerializeField]
	private int space;

	[SerializeField]
	private Vector2 popOrigin;

	[SerializeField]
	private GameObject goArrow;

	public RectTransform RewardRect;

	private EquipDownEndData data;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
