using System.Collections.Generic;
using UnityEngine;

public class ArtifactData
{
	public int BelongEntityGuid { get; set; }

	public Transform ArtifactParent { get; set; }

	public ArtifactRecycleType RecycleType { get; set; }

	public bool IsUnloading { get; set; }

	public ArtifactShowParent ArtifactObjParent { get; set; }

	public List<ArtifactItemData> DataItems { get; set; }

	public float RotateSpeed => 0f;

	public static ArtifactData Create(int belongEntityGuid, Transform artifactParent, ArtifactRecycleType recycleType)
	{
		return null;
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void SetArtifactItemActive(ArtifactItemData itemData, ArtifactItemStatus artifactItemStatus, bool needUpdateRotate)
	{
	}

	public ArtifactShowItem ChangeArtifactItemModel(int artifactID, string modelID)
	{
		return null;
	}

	public void DestroyArtifactItem(ArtifactItemData itemData)
	{
	}

	public void UpdateArtifactObjParent(ArtifactShowParent artifactObjParent)
	{
	}

	public void UpdateArtifactRotate()
	{
	}
}
