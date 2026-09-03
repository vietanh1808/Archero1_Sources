using UnityEngine;
using UnityEngine.UI;

public class ArtifactAttrItem : MonoBehaviour
{
	public RectTransform RTF;

	public Image Image_BG;

	public ArtifactStarShowItem starItem;

	public GameObject SkillObj;

	public GameObject SkillMask;

	public Image Image_SkiBG;

	public Image Image_SkiIcon;

	public GameObject cpItem;

	public RectTransform Content;

	private static readonly Color bgcolor;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	private ArtifactAttrItemData itemData;

	public void init(ArtifactAttrItemData data, int haveStar)
	{
	}

	public void freshItem(int haveStar)
	{
	}

	public void onButtonSkill()
	{
	}

	public float GetItemHeight()
	{
		return 0f;
	}
}
