using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityRank : MonoBehaviour
{
	[SerializeField]
	private HeadItem _headItem;

	[SerializeField]
	private ButtonCtrl _btn;

	[SerializeField]
	private Image _imgRankBg;

	[SerializeField]
	private DxxText _textRank;

	[SerializeField]
	private DxxText _textTalent;

	public void Init(STActivityArtifactTrialRankItem data, bool bIsSelf = false)
	{
	}
}
