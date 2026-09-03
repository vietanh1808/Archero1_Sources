using UnityEngine;
using UnityEngine.UI;

public class WeaponColorAttPart : MonoBehaviour
{
	public WeaponColorAttrItem template;

	public RectTransform rectParent;

	public RectTransform rectBg;

	public ScrollRect scrollRect;

	public DxxText tipsTitleText;

	private LocalUnityObjctPool _pool;

	private float _minScrollHeight;

	private float _maxScrollHeight;

	public void Init()
	{
	}

	public void OnOpen(int typeInfoID)
	{
	}
}
