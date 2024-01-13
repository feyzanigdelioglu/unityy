using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void StartGame()
    {
        // Oyunu başlatan kod
        SceneManager.LoadScene("AnaOyunSahnesi"); // "AnaOyunSahnesi" sahnesinin adını kendi sahnenizin adıyla değiştirin
    }
}
