using UnityEngine;

public class SailingMilitaryRankTip : MonoBehaviour
{
	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textContent1;

	[SerializeField]
	private DxxText _textContent2;

	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private SailingMilitaryRankTipItem _copyone;

	[SerializeField]
	private Transform _content;

	private LocalUnityObjctPool _pool;

	public void Init()
	{
	}

	public void Close()
	{
	}
}
