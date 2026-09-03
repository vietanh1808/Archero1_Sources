using UnityEngine;

public class FoodClearnessBase : FoodBase
{
	[SerializeField]
	private MeshRenderer clearnessMesh;

	[SerializeField]
	private SpriteRenderer clearnessShadowSprite;

	[SerializeField]
	private SpriteRenderer clearnessEquipSprite;

	private MaterialPropertyBlock propertyBlock;

	private float clearnessEquipSpriteOriginAlpha;

	private float clearnessShadowSpriteOriginAlpha;

	protected override void OnAwakeInit()
	{
	}

	protected virtual void InitAlphaData()
	{
	}

	protected override void SetPropClearness(BattlePropClearness clearness)
	{
	}
}
