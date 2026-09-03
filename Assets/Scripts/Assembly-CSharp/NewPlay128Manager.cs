using UnityEngine;

public class NewPlay128Manager : CInstance<NewPlay128Manager>
{
	public const string LOG_TAG = "[NewPlay128]";

	public const int SELF_TEAM_ID = 2025128;

	private bool initialized;

	private bool haveInit;

	public EntityArtifactBase centerArtifact;

	public EntityArtifactBase CenterArtifact => null;

	public Vector3 CenterArtifactPos => default;

	protected override void Init()
	{
	}

	protected override void ReLogin()
	{
	}

	protected override void Clear()
	{
	}

	private void _OnInit()
	{
	}

	private void _OnDeInit()
	{
	}

	public void CreateNewPlay128ArtifactCenter()
	{
	}

	public EntityArtifactBase CreateNewPlay128ArtifactById(int charId, Vector3 pos)
	{
		return null;
	}
}
