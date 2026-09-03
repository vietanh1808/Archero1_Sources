using UnityEngine;
using UnityEngine.UI;

public class EquipStyleNameCtrl : MonoBehaviour
{
	public GameObject child;

	public Image Image_BG;

	public DxxText Text_Name;

	private FoodBase equipitem;

	private float Image_BGOriginAlphaValue;

	private float Text_NameOriginAlphaValue;

	private const float ShowPropNameOffsetY = 70f;

	private const float HidePropNameOffsetY = -5f;

	private const float HIdePropScale = 0.4f;

	private bool IsShowPropName => false;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void Init(FoodEquipStyleBase equip, string name, int count, Color qualityColor)
	{
	}

	public void SetImgAlpha(float value)
	{
	}
}
