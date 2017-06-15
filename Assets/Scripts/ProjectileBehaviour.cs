﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public Projectile projectileConfig;
    public int Dmg;

	// Use this for initialization
	void Start ()
	{
	    Dmg = projectileConfig.Damage;
	}

    void OnTriggerEnter(Collider other)
    {
    if(other.CompareTag("Player"))
        Destroy(this.gameObject);
    }

}
