using UnityEngine;

public class ChooseArtifactActivitySkillUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _btnConfirm;

	[SerializeField]
	private DxxText _textConfirm;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textDesc;

	[SerializeField]
	private ChooseArtifactActivitySkillOne[] _skillOnes;

	private ChooseArtifactActivitySkillOne _selectOne;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnSelectOne(ChooseArtifactActivitySkillOne selectOne)
	{
	}
}
