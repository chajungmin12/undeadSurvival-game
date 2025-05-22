using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public int per;

    public void Iint(float damage, int per){
        this.damage = damage;
        this.per = per;
    }


}
