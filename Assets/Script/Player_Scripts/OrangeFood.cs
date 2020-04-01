﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OrangeFood : MonoBehaviour {

    public float Depletion = 100;
    public Transform barTransform;
    public GameObject radius;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update(){

    }

    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Cat")) {
            Debug.Log($"Depletion = {Depletion}");
            Depletion--;
            barTransform.localScale = new Vector3(0.5f * (Depletion / 100), 0.04f, 1);
            if (Depletion <= 0) {
                Destroy(gameObject);
            }
        } else {
            Debug.Log(collision.gameObject.tag);
        }
    }

    IEnumerator Despawn(int seconds) {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
