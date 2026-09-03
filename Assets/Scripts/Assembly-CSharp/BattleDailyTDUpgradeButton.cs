using UnityEngine;

public class BattleDailyTDUpgradeButton : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxText txtPrice;

	[SerializeField]
	private DxxText txtUpgrade;

	[SerializeField]
	private RectTransform rt;

	private bool shown;

	private int instanceId;

	private bool rightHanded;

	private float min => 0f;

	private float max => 0f;

	private float end => 0f;

	private float start => 0f;

	private float _speed => 0f;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	public void Open(int instanceId)
	{
	}

	public void SetHand(bool rightHanded)
	{
	}

	public void CloseInstant()
	{
	}

	public void Close()
	{
	}

	public void UpdateState()
	{
	}

	private void Update()
	{
	}
}
