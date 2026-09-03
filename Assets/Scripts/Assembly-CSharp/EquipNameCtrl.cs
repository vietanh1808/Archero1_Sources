using UnityEngine;
using UnityEngine.UI;

public class EquipNameCtrl : MonoBehaviour
{
	public GameObject child;

	public Image Image_BG;

	public DxxText Text_Name;

	private FoodEquipBase equipitem;

	private const float ShowPropNameOffsetY = 70f;

	private const float HidePropNameOffsetY = -5f;

	private const float HIdePropScale = 0.4f;

	private float Image_BGOriginAlphaValue;

	private float Text_NameOriginAlphaValue;

	private bool IsShowPropName => false;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void Init(FoodEquipBase equip)
	{
	}

	public void SetImgAlpha(float value)
	{
	}
}
