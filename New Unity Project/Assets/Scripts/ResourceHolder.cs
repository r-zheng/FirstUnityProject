using UnityEngine;

public class ResourceHolder : MonoBehaviour
{
    public static GameObject enemyShip;
    public static GameObject playerShipObject;
    public static GameObject hpBar;
    public static GameObject weaponManager;
    public static GameObject armorManager;
    public static WeaponBehavior enemyWeaponBehavior;
    public static Weapon enemyWeapon;
    public static Armor enemyArmor;
    public static ArmorStats enemyArmorStats;
    public static ScoreBoard score;

    public void Awake()
    {
        enemyShip = (GameObject)Resources.Load("EnemyShip", typeof(GameObject));
        playerShipObject = GameObject.Find("Player");
        hpBar = GameObject.Find("HpBar");
        weaponManager = GameObject.Find("WeaponScreen");
        armorManager = GameObject.Find("ArmorScreen");
        enemyWeaponBehavior = (WeaponBehavior)Resources.Load("EnemyWeaponBehavior", typeof(ScriptableObject));
        enemyWeapon = (Weapon)Resources.Load("EnemyWeapon", typeof(ScriptableObject));
        enemyArmor = (Armor)Resources.Load("EnemyArmor", typeof(ScriptableObject));
        enemyArmorStats = (ArmorStats)Resources.Load("EnemyArmorStats", typeof(ScriptableObject));
        score = GameObject.Find("Score").GetComponent<ScoreBoard>();
        Debug.Log(enemyShip);
    }
}