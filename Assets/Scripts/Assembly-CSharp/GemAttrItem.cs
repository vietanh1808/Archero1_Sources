using UnityEngine;
using UnityEngine.UI;

public class GemAttrItem : MonoBehaviour
{
	public Image point;

	public Image locker;

	public DxxText attrText;

	[SerializeField]
	private Sprite[] color;

	private static Color color1;

	private static Color color2;

	public void init(GemLevelAttr attr, int haveLevel)
	{
	}
}
