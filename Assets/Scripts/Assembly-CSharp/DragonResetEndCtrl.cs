using UnityEngine;

public class DragonResetEndCtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private TapToCloseCtrl closeCtrl;

	[SerializeField]
	private EquipOneCtrl resetItem;

	[SerializeField]
	private PropOneEquip[] props;

	[SerializeField]
	private ButtonCtrl btnScreen;

	[SerializeField]
	private int space;

	[SerializeField]
	private Vector2 popOrigin;

	[SerializeField]
	private GameObject goArrow;

	private DragonResetEndData data;

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
