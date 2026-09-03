using Habby.Guild.Data;
using UnityEngine;
using UnityEngine.UI;

public class GuildActivityChestItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxText txtLevel;

	[SerializeField]
	private Transform scaleRoot;

	[SerializeField]
	private Transform canvasRoot;

	[SerializeField]
	private Transform nonCanvasRoot;

	[SerializeField]
	private Transform chestRoot;

	[SerializeField]
	private GuildActivityUICtrl root;

	[SerializeField]
	private GuildChestRewardPreview preview;

	[SerializeField]
	private GameObject goEffect;

	private int activityId;

	private int giftId;

	private int index;

	private float width;

	private float unitX;

	private ActivityGiftBox data;

	private float pos;

	public Image Image_Box;

	private void Awake()
	{
	}

	private void OnBtnChestClick()
	{
	}

	private void OnEnable()
	{
	}

	private void ClaimGift(ActivityGiftBox gift)
	{
	}

	public void SetData(int index, int activityId, GuildActivityUICtrl root)
	{
	}

	private void SetStyle()
	{
	}

	private void ShowEffect(bool show)
	{
	}
}
