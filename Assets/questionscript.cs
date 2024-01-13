using UnityEngine;

public class GameInfoPrinter : MonoBehaviour
{
    void Start()
    {
        // Oyun bilgilerini yazdirma ornegi
        PrintGameInfo();
    }

    void PrintGameInfo()
    {
        // Oyun adi
                Debug.Log("Oyun Adi: " + Application.productName);

        // Oyun versiyonu
        Debug.Log("Oyun Versiyonu: " + Application.version);

        // Oyun ID'si
        Debug.Log("Oyun ID'si: " + Application.identifier);

        // Oyun platformu
        Debug.Log("Oyun Platformu: " + Application.platform);

        // Ekran çözünürlüğü
        Debug.Log("Ekran Çözünürlüğü: " + Screen.width + "x" + Screen.height);

        // Ekran yenileme hızı
        Debug.Log("Ekran Yenileme Hızı: " + Screen.currentResolution.refreshRate);

        // Cihazın bellek boyutu
        Debug.Log("Bellek Boyutu: " + SystemInfo.systemMemorySize + " MB");

        // Grafik API'si
        Debug.Log("Grafik API'si: " + SystemInfo.graphicsDeviceType);

        // Grafik bellek boyutu
        Debug.Log("Grafik Bellek Boyutu: " + SystemInfo.graphicsMemorySize + " MB");

        // Grafik
