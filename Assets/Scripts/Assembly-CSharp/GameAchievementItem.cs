using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAchievementItem : MonoBehaviour
{
	public Text TitleText;

	public Text PercentText;

	public Text GetRewardText;

	public Image GetRewardImg;

	public GameObject Content;

	public ButtonCtrl GetBtn;

	public Slider Slider;

	private LocalUnityObjctPool Pool;

	public GameAchievementBase.GameAchievementElement Data;

	public Color NormalColor;

	public Color FinishColor;

	public PropOneEquip CopyProp;

	public GridLayoutGroup RewardParent;

	public RectTransform rect_Icons;

	public DxxImage[] showIcons;

	private List<PropOneEquip> RewardList;

	[SerializeField]
	private Sprite blue;

	[SerializeField]
	private Sprite green;

	public Image Slider_Fill;

	public void SetData(GameAchievementBase.GameAchievementElement data)
	{
	}

	public void Refresh()
	{
	}

	public virtual void OnLanguageChange()
	{
	}
}
