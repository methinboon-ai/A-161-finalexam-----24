using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool isEffectActive = false;
    public abstract void ApplyEffect(Player player);
}
