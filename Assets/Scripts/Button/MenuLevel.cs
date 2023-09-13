using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLevel : MonoBehaviour
{
    public static int numara;
    [SerializeField]
    Button bIleri, bGeri;
    [SerializeField]
    Text numaraText;
    public static int active;
    private void Start()
    {
        numara = SceneManager.GetActiveScene().buildIndex;
        bIleri.enabled = false;
        PlayerPrefs.SetInt("Level", numara);
        numaraText.text = numara.ToString();
        if(numara == 1)
        {
            bGeri.enabled = false;
            bGeri.image.enabled = false;
        }
        if(numara == 16)
        {
            bIleri.enabled = false;
            bIleri.image.enabled = false;
        }
    }
    void ileriGeri()
    {
        parkYeri.Park = 0;
        b();
        move.GasBrake = true;
        move.Gas = false;
        move.Brake = false;
    }
    public void ileri()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ileriGeri();
    }
    public void geri()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ileriGeri();
    }
    private void b()
    {
        if (ContinuePause.bContinue == true)
        {
            active = 1;
        }
        else if (AgainMenu.bAgain == true)
        {
            active = 2;
        }
        else if (AgainMenu.bNoMoney == true)
        {
            active = 3;
        }
    }
}
