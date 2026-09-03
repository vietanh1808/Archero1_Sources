using UnityEngine;

public class EquipStorageTotemTipsItem : MonoBehaviour
{
	[SerializeField]
	private TotemAttTxtItem attItem;

	[SerializeField]
	private DxxText totemName;

	[SerializeField]
	private RectTransform rectParent;

	[SerializeField]
	private GameObject refineLevelRoot;

	[SerializeField]
	private GameObject refineNormalFrame;

	[SerializeField]
	private GameObject refineMaxFrame;

	[SerializeField]
	private DxxText refineLevelText;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	public void Init(TotemItemData data, Vector2 pos)
	{
	}
}
