using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsinBullet;


    public GameObject createBullet(BulletTypes type)
    {
        GameObject tempBullet = new GameObject();
        switch(type)
        {
            case BulletTypes.REGULAR:
                tempBullet = Instantiate(regularBullet);
                break;
            case BulletTypes.FAT:
                tempBullet = Instantiate(fatBullet);
                break;
            case BulletTypes.PULSING:
                tempBullet = Instantiate(pulsinBullet);
                break;
        }

        return tempBullet;
        
    }
}
