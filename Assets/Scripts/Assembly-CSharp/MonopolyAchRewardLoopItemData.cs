public class MonopolyAchRewardLoopItemData : MonopolyAchRewardItemData
{
	public override Act5thTorchRewardStatus Status => Act5thTorchRewardStatus.None;

	public override int Left => 0;

	private int RateLeft => 0;

	public override float Rate => 0f;

	public override bool isLoop => false;
}
