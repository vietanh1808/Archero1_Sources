using System;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class ChooseArtifactActivitySkillOne : MonoBehaviour
{
	[SerializeField]
	private Image _bg;

	[SerializeField]
	private Image _skillIcon;

	[SerializeField]
	private Image _artifactIcon;

	[SerializeField]
	private Image _select;

	[SerializeField]
	private Image[] _imgStars;

	[SerializeField]
	private DxxText _textDesc;

	[SerializeField]
	private ButtonCtrl _btn;

	private LocalSave.ArtifactOne _data;

	private int _skillId;

	private Image _imgNextStar;

	private SequencePool _sequencePool;

	public LocalSave.ArtifactOne Data => null;

	public int SkillId => 0;

	public int ArtifactId => 0;

	public void Init(LocalSave.ArtifactOne data, int skillId, bool isSelect, Action<ChooseArtifactActivitySkillOne> onClick)
	{
	}

	public void Select()
	{
	}

	public void Unselect()
	{
	}

	public void Close()
	{
	}
}
