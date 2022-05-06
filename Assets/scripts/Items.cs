using UnityEditor;
using UnityEngine;

public class Items : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            Debug.Log(GameObject.FindGameObjectsWithTag("apple").Length);
            if ( GameObject.FindGameObjectsWithTag("apple").Length == 1)
            {
                Debug.Log("moi");
                Application.Quit();
                EditorApplication.ExitPlaymode();
            }
          
        }



    }
}