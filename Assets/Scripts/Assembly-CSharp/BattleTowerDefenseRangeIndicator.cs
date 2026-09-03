using UnityEngine;
using XLua;

[RequireComponent(typeof(SpriteRenderer))]
public class BattleTowerDefenseRangeIndicator : MonoBehaviour
{
	private SpriteRenderer sr;

	private int type;

	private int instanceId;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_GetSprite;

	private static DelegateBridge __Hotfix0_OnEnable;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void SetData(Vector3 position, Vector2 range, int type, int instanceId)
	{
	}

	private static Sprite GetSprite(int type)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
