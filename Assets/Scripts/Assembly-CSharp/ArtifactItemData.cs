using System;
using Newtonsoft.Json;
using TableTool;
using UnityEngine;

[Serializable]
public class ArtifactItemData
{
	public int ID;

	public int SkillID;

	public string ModelID;

	[JsonIgnore]
	public Artifact_Artifact Config { get; set; }

	[JsonIgnore]
	public ArtifactItemStatus Status { get; set; }

	[JsonIgnore]
	public ArtifactShowItem Model { get; set; }

	[JsonIgnore]
	public int BelongEntityGuide { get; set; }

	[JsonIgnore]
	public Transform ArtifactObjParent { get; set; }

	[JsonIgnore]
	public ArtifactType ArtifactType => ArtifactType.None;

	[JsonIgnore]
	public bool IsShow => false;

	[JsonIgnore]
	public float Scale => 0f;

	[JsonIgnore]
	public float Position => 0f;

	[JsonIgnore]
	public float Height => 0f;

	[JsonIgnore]
	public float RotateSpeed => 0f;

	[JsonIgnore]
	public float[] ArtifactSelfParentRotate => null;

	[JsonIgnore]
	public Quaternion ModelRotation => default;

	public static ArtifactItemData Create(int id, int skillId, string modelId)
	{
		return null;
	}

	public void SetModel(ArtifactShowItem model)
	{
	}

	public ArtifactShowItem ChangeMode(string modelID)
	{
		return null;
	}

	public void Refresh(ArtifactItemStatus status, Transform artifactObjParent, int belongEntityGuide)
	{
	}

	public void RefreshModel()
	{
	}

	public void SetModePublicRotate(float rotate)
	{
	}

	public Vector3 GetModelLegalPosition(float offset = 1f)
	{
		return default;
	}

	public void Deinit()
	{
	}
}
