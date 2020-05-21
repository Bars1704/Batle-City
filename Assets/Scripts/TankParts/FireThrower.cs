﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireThrower : ApproxWeapon
{
    public int BulletCount;
    
    
    protected override void Shoot()
    {
        InitializeWeapon();
        for (int i = 0; i < BulletCount; i++)
        {
            var EylerAngles = transform.rotation.eulerAngles;
            var apr = Random.Range(Approximate * -1, Approximate);
            EylerAngles.z += apr;
            var pos = MakeOtstup(transform.position);
            Instantiate(bullet, pos, Quaternion.Euler(EylerAngles));     
        }
    }

    new private void Update()
    {
        base.Update();
        if (Input.GetKeyDown(shoot))
        {
            PlaySound();
        }
        if (Input.GetKeyUp(shoot))
        {
            aSource.Pause();
        }
    }
}
