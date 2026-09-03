using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactGameSkillStar : MonoBehaviour
{
	[SerializeField]
	private Image star;

	private const float FadeTime = 1f;

	private SequencePool sequencePool;

	private ArtifactGameSkillStarStatus status;

	public void Refresh(ArtifactGameSkillStarStatus status)
	{
	}
}
