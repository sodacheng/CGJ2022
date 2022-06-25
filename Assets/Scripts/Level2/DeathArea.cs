using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CylinderController.allowControl = false;
            //Restart
            SceneManager.LoadScene("Level3");


        }
    }

    
}
