using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.instance.HitSound();
        Object.Destroy(gameObject , 0.0f);
    }

}
