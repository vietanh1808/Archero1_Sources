using TableTool;
using UnityEngine;

public class TotemPreviewItem : MonoBehaviour
{
	[SerializeField]
	private DxxText mainAttrText;

	[SerializeField]
	private RectTransform subAttrContent;

	[SerializeField]
	private TotemPreviewSubItem subAttrTemplate;

	private LocalUnityObjctPool _pool;

	public void Init(Equip_equip config)
	{
	}
}
