using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsinBullet;


    public GameObject createBullet(BulletTypes type = BulletTypes.RANDOM)
    {
        if(type == BulletTypes.RANDOM)
        {
            var randombullet = Random.Range(0, 3);
            type = (BulletTypes)randombullet;
        }

        GameObject tempBullet = null;
        switch(type)
        {
            case BulletTypes.REGULAR:
                tempBullet = Instantiate(regularBullet);
                tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case BulletTypes.FAT:
                tempBullet = Instantiate(fatBullet);
                tempBullet.GetComponent<BulletController>().damage = 20;
                break;
            case BulletTypes.PULSING:
                tempBullet = Instantiate(pulsinBullet);
                tempBullet.GetComponent<BulletController>().damage = 30;
                break;
        }
        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);
        return tempBullet;
        
    }
}
