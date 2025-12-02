using UnityEngine;

public class Mud : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (isEffectActive == true) return;
        isEffectActive = true;
        // Logic
        float newSpeed = player.moveSpeed/2; // Slowed Speed
        player.SetMoveSpeed(newSpeed);
        Debug.Log($"Player Slowed!");
        Destroy(gameObject);
    }
}
