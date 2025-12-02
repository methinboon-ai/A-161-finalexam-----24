using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (isEffectActive == true) return;
        isEffectActive = true;
        // Logic
        float newSpeed = player.moveSpeed * 2;
        player.SetMoveSpeed(newSpeed);
        Destroy(gameObject);
    }
}
