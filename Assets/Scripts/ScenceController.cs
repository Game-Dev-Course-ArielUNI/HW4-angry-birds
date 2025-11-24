using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceController : MonoBehaviour
{
    public static ScenceController Instance;

    private void Start()
    {
        // Check if an instance of ScenceController already exists
        if (Instance == null)
        {
            // Assign this as the singleton instance
            Instance = this;

            // Prevent this GameObject from being destroyed when loading new scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If another instance already exists, destroy this duplicate
            Destroy(gameObject);
        }
    }

    // Method to load the next level based on the current scene's build index
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to load a specific scene by its name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
