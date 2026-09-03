using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarvingCombineEndCtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Quality;

	[SerializeField]
	private RectTransform iconParent;

	[SerializeField]
	private RectTransform attrParent;

	[SerializeField]
	private GameObject successParent;

	[SerializeField]
	private GameObject attributeParent;

	[SerializeField]
	private DxxText Text_Success;

	[SerializeField]
	private GameObject effectThunder;

	[SerializeField]
	private GameObject effectRotate;

	[SerializeField]
	private GameObject effectBomb;

	[SerializeField]
	private GameObject copyAttr;

	public TapToCloseCtrl mCloseCtrl;

	private LocalUnityObjctPool mPool;

	private DragonCombineEndData endData;

	private readonly List<CarvingCombineAttr> attrs;

	private AnimationCurve curve_sin;

	private GameObject[] effectCombinings;

	private UISortOrder effectEnd;

	private UISortOrder effectLight;

	private Dictionary<int, UISortOrder> effectFronts;

	public Button touchScreenButton;

	public GameObject effectFireObj;

	private LocalSave.EquipOne result;

	private List<LocalSave.EquipOne> materials;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void show_effect_front(bool value)
	{
	}

	private void show_effect_combining(bool value, EquipOneCtrl[] items = null)
	{
	}

	private void show_effect_end(bool value, EquipOneCtrl middle)
	{
	}

	private void show_effect_light(bool value, EquipOneCtrl middle)
	{
	}

	private void update_canvas(GameObject o, bool add)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnButtonTouchScreen()
	{
	}

	private float GetPositionX(int total, int index)
	{
		return 0f;
	}
}
