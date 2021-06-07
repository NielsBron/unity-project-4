using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour {

    public GameObject MyWeapon;
    public GameObject GroundWeapon;
    void Start() {
        MyWeapon.SetActive(false);

    }

    void OnTriggerEnter(Collider _collider)
    {
        if (_collider.gameObject.tag == "Player")
        {
            MyWeapon.SetActive(true);
            GroundWeapon.SetActive(false);
        }
    }

        

}
