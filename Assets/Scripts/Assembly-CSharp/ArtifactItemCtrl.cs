using UnityEngine;
using UnityEngine.UI;

public class ArtifactItemCtrl : MonoBehaviour
{
	[SerializeField]
	private Image _bg;

	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Image _mask;

	[SerializeField]
	private Image _imgStarBg;

	[SerializeField]
	private Image[] _imgStars;

	[SerializeField]
	private Text _txtStar;

	private ArtifactType _artifactType;

	public ArtifactType ArtifactType => ArtifactType.None;

	public ArtifactItemCtrl Init(LocalSave.ArtifactOne data)
	{
		return null;
	}

	public void OnUpdate(float percent)
	{
	}
}
