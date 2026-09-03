using UnityEngine;

public class SkinCardEnhanceItem : EnhanceItem
{
	public DxxImage SelectBorder;

	public DxxImage lockImg;

	[SerializeField]
	private GameObject collectRewardBtn;

	protected override void OnUpdateItemRender()
	{
	}

	public override void SetSelectState(bool isCenter)
	{
	}

	public void OnClick()
	{
	}

	protected override void OnClickEnhanceItem()
	{
	}

	public void RefreshCollectRewardState()
	{
	}

	private void OnCollectRewardClicked()
	{
	}

	protected override void OnClose()
	{
	}
}
