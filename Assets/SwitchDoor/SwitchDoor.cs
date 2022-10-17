using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public GameObject[] doorObjects;
    public SpriteRenderer _spriteRenderer;
    private bool switchActive = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            switchActive = !(switchActive);
            _spriteRenderer.flipX = switchActive;
            foreach(GameObject doorObject in doorObjects) {
                doorObject.SetActive(!switchActive);
            }
        }
    }

}
