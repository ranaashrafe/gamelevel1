﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour {
	public GameObject TheGun;
	public GameObject MuzzleFlash;
	public AudioSource GunFire;
	public bool IsFiring = false;

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			if (IsFiring == false) {
				StartCoroutine (FiringPistol ());

			}
		}
		
	}
	IEnumerator FiringPistol(){
		IsFiring = true;
		TheGun.GetComponent<Animation> ().Play("PistolShot");
		MuzzleFlash.SetActive (true);
		MuzzleFlash.GetComponent<Animation> ().Play ("MuzzleAnim");


		GunFire.Play();
		yield return new WaitForSeconds (0.5f);
		IsFiring = false;
	}
}
