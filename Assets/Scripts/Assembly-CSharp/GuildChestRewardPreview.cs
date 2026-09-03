using UnityEngine;

public class GuildChestRewardPreview : MonoBehaviour
{
	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private RectTransform contentRoot;

	[SerializeField]
	private GameObject template;

	[SerializeField]
	private PointerDownHandler pointerDownHandler;

	private LocalUnityObjctPool pool;

	private int activityId;

	private int giftId;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Set(int activityId, int giftId)
	{
	}
}
