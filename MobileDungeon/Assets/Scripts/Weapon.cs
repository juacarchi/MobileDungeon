using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Arma",menuName ="Weapon",order = 1)]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public int damage, bulletsPerTap, magazineSize;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    public bool ShootDuringAim;

    
}
