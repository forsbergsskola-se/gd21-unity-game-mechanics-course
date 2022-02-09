using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSceneOnPlayerDeath : MonoBehaviour
{
    [SerializeField] private float sceneReloadDelay = 3f;

    public void StartReloadSceneCoroutine()
    {
        // Debug.Log("Start scene reload coroutine.");
        StartCoroutine(ReloadActiveSceneCoroutine());
    }

    private IEnumerator ReloadActiveSceneCoroutine()
    {
        // Debug.Log("Waiting to reload scene.");
        yield return new WaitForSeconds(sceneReloadDelay);
        ReloadActiveScene();
    }

    private static void ReloadActiveScene()
    {
        //Restart level by loading the active scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}