using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu (menuName = "ChangeSceneOrQuit")]
public class ChangeSceneOrQuit : ScriptableObject
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
