using UnityEngine;

public abstract class Ship : MonoBehaviour
{
    public Armor armor;
    public Weapon weapon;
    public ShipControl shipControl;
    public GameObject firePoint;

    public void UpdateArmor()
    {

    }

    public void UpdateWeapon()
    {

    }

    public virtual void BlowUp()
    {
        Destroy(gameObject);
    }

    public void FixedUpdate()
    {
        shipControl.DoControls();
        weapon.behavior.FireUpdate(firePoint.transform.position);
    }

    public virtual void TakeDamage(float damage, GameObject shipObject)
    {
        armor.TakeDamage(damage, shipObject);
    }
}