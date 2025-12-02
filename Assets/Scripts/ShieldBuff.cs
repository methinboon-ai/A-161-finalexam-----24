using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (isEffectActive == true) return;
        isEffectActive = true;
        // Logic
        player.SetInvulnerability(true);
        Destroy(gameObject);
    }
}
