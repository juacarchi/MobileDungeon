using UnityEngine;

public class GunSystem : MonoBehaviour
{
    Weapon actualWeapon;
    int damage;
    float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    int magazineSize, bulletsPerTap;
    int bulletsLeft, bulletsShot;

    //boolsGameplay
    bool shooting, readyToShoot, reloading;

    //Reference
    public VariableJoystick joystickAttack;
    public Transform attackPoint;
    RaycastHit rayHit;
    LayerMask whatIsEnemy;

    public static GunSystem instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        actualWeapon = new Weapon();
    }
    //JOYSTICK DETECTION
    public void OnPointerUp()
    {
        shooting = true;
        if (bulletsLeft < magazineSize && !reloading) Reload();
        //SHOOT
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        readyToShoot = false;
        //RAYCAST
        //if(Physics.Raycast())

        bulletsLeft--;
        Invoke("ResetShoot", timeBetweenShooting);
    }
    void ResetShoot()
    {
        readyToShoot = true;
    }
    void Reload()
    {

    }

    private void Update()
    {
        if (shooting)
        {
            Debug.Log("DISPARA");
            shooting = false;
        }

    }
}
