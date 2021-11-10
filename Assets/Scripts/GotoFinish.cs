using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoFinish : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] NumberFields scoreField;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
        }
    }
}
