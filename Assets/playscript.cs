using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void StartGame()
    {
        // Oyunu baslatan kod
        SceneManager.LoadScene("AnaOyunSahnesi"); // "AnaOyunSahnesi" sahnesinin adini kendi sahnenizin adiyla degistirin
    }
}
