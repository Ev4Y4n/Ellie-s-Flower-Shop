using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosCallendo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Barrera"))
        {
            Destroy(this.gameObject);
        }
            
    }
}
