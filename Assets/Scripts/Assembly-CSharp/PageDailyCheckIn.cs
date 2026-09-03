using UnityEngine;

public class PageDailyCheckIn : UserBackPageBase
{
	[SerializeField]
	private RectTransform contentRoot;

	[SerializeField]
	private GameObject propOneTemplate;

	[SerializeField]
	private GameObject setItemTemplate;

	private LocalUnityObjctPool pool;

	public override void OnInit()
	{
	}

	private void OnEnable()
	{
	}

	public override void UpdateUI(bool reset = false)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
