using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nexLevelIdex = 1;
    private Enemy[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
        }

        _nexLevelIdex++;

        string nextLevelName = "Level" + _nexLevelIdex;
        SceneManager.LoadScene(nextLevelName);
    }
}
