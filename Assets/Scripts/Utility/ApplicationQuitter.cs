using UnityEngine;

public class ApplicationQuitter : MonoBehaviour
{
    public void Quit()
    {
        //Example of platform dependent compilation.
#if UNITY_EDITOR
        //This only runs if we're playing the game INSIDE of the Unity editor.
        UnityEditor.EditorApplication.ExitPlaymode(); //Let's us exit playmode.
#else
        //This only runs if we're playing the game OUTSIDE of the Unity editor. For example in a build of the game.
        Application.Quit(); //Closes the game.
#endif
    }
}