using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextNumbar : MonoBehaviour
{
    int numara;
    [SerializeField]
    Text numaraText;
    private void Start()
    {
        numara = SceneManager.GetActiveScene().buildIndex;
        numaraText.text = numara.ToString();
    }
}
