using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyon2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            Destroy(this.gameObject);
            //game over
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
