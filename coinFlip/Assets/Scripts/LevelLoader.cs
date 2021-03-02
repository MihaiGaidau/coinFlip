using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    public void LoadLevel(int sceneId)
    {
        SceneManager.LoadSceneAsync(sceneId);
    }

}
