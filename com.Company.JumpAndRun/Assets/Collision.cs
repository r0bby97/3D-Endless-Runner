using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("menu");
        }
   }
}
