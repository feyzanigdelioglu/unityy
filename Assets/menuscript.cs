using UnityEngine;

public class SoundControl : MonoBehaviour
{
    void Start()
    {
        // Oyun basladiginda sesi kapat
        AudioListener.volume = 0f;
    }

    // istege bagli olarak bu kodu bir buton veya baska bir etkilesimle cagirabilirsiniz
    void Update()
    {
        // ornek: Klavye girisiyle sesi kapatmak icin
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleSound();
        }
    }

    // Sesin durumunu degistiren fonksiyon
    void ToggleSound()
    {
        AudioListener.volume = (AudioListener.volume == 0f) ? 1f : 0f;
    }
}
