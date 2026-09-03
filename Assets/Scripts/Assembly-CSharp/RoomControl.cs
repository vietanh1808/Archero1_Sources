using UnityEngine;

public class RoomControl : RoomControlBase
{
	private static Color[] ColorLights;

	private static Color[] ColorShadows;

	private const string DoorAnimationName = "MapDoor_Miss";

	private RoomGenerateBase.Room room;

	private RoomGenerateBase.Room nextRoom;

	private RoomGateCtrl mGateCtrl;

	private GameObject layerObj;

	private GameObject bossObj;

	private Canvas instructionCanvas;

	private DxxText txt_selfTeam;

	private DxxText txt_opponentTeam;

	private Canvas tipCanvas;

	private DxxText txt_selfTeamTip;

	private DxxText txt_opponentTeamTip;

	protected override void OnAwake()
	{
	}

	protected override void OnInit(object data = null)
	{
	}

	protected override void OnLayerShow(bool value)
	{
	}

	protected override void OnSetText(string value)
	{
	}

	protected override void OnOpenDoor(bool show)
	{
	}

	private void Update()
	{
	}

	private void DoorDownShow()
	{
	}

	private void ExcuteLayer()
	{
	}

	protected override void OnClearGoods()
	{
	}

	protected override void OnClearGoodsDrop()
	{
	}

	protected override Transform OnGetGoodsDropParent()
	{
		return null;
	}

	private void forceLayerInvisible()
	{
	}

	private void initInstructionCanvas()
	{
	}

	private void initTipCanvas()
	{
	}

	public void SetTipCanvas(bool visible)
	{
	}

	public void InitInDefenseTip()
	{
	}

	public void InitInAttackTip()
	{
	}

	public void InitInDefense()
	{
	}

	public void InitInAttack()
	{
	}

	public void SetTxtSelfTeamVisible(bool visible)
	{
	}

	public void SetTxtOpponentTeamVisible(bool visible)
	{
	}

	public void SetInstructionCanvasVisible(bool visible)
	{
	}

	private void OnInitStage()
	{
	}

	private void InitStage3()
	{
	}
}
