using UnityEngine;
using UnityEngine.UI;

public class PlayerShip : Ship
{
    public Slider hpBar;
    public GameObject hpText;

    public void Start()
    {
        shipControl = new PlayerControls(transform.gameObject);
        weapon.CreateWeapon(gameObject);
        armor.CreateArmor(gameObject);
        weapon.CreateMods(weapon);
        armor.CreateMods(armor);
    }

    public override void BlowUp()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        ResourceHolder.score.EndGame(false);
        enabled = false;
    }

    public override void TakeDamage(float damage, GameObject shipObject)
    {
        float hpValue = armor.TakeDamage(damage, shipObject) / ((ArmorStats)armor.stats).maxShields * 100;
        hpBar.value
            = hpValue;
        hpText.GetComponent<Text>().text = ((int)((ArmorStats)(armor.stats)).Shields).ToString() + " / " + ((int)((ArmorStats)(armor.stats)).maxShields).ToString();
    }

    public void ChangeEquipment(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void ChangeEquipment(Armor armor)
    {
        this.armor = armor;
    }
}