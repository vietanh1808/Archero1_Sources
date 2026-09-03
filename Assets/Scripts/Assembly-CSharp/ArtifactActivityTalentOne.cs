using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityTalentOne : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl _btn;

	[SerializeField]
	private Image _imgIcon;

	[SerializeField]
	private Image _imgUnknown;

	[SerializeField]
	private Image _imgQuality;

	[SerializeField]
	private Image[] _vecImgStars;

	[SerializeField]
	private DxxText _txtName;

	private Action<ArtifactActivityTalentOne> _clickCallback;

	private Daily_TrialTalent_128 _data;

	public Daily_TrialTalent_128 Data => null;

	public void Init(Daily_TrialTalent_128 data, Action<ArtifactActivityTalentOne> clickCallback)
	{
	}
}
