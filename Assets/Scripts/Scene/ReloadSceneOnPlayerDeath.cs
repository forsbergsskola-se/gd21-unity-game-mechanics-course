using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSceneOnPlayerDeath : MonoBehaviour
{
    [SerializeField] private PlayerIdentifier playerIdentifier;
    [SerializeField] private float sceneReloadDelay = 3f;

    private bool reloadCoroutineStarted;

    private void Update()
    {
        if (playerIdentifier == null && reloadCoroutineStarted == false) //If the player no longer exists.
        {
            StartCoroutine(ReloadActiveSceneCoroutine());
        }
    }

    private IEnumerator ReloadActiveSceneCoroutine()
    {
        // Debug.Log("Waiting to reload scene.");
        reloadCoroutineStarted = true;
        yield return new WaitForSeconds(sceneReloadDelay);
        ReloadActiveScene();
        // reloadCoroutineStarted = false; //Since we're reloading the entire scene when this coroutine finishes, it's not really necessary to reset the bool.
    }

    private static void ReloadActiveScene()
    {
        //Restart level by loading the active scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}