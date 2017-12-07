using UnityEngine;

[CreateAssetMenu(menuName = "WeaponBehavior/PlayerWeapon")]
public class PlayerWeaponBehavior : WeaponBehavior
{
	public override void FireUpdate(Vector3 firePointPos)
    {
		if(Input.GetKey(KeyCode.Mouse0) && Time.time > timeToFire)
        {
            timeToFire = Time.time + stats.GetFireCooldown();
            Shoot(firePointPos);
        }
	}
}
