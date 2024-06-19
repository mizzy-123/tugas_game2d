using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditButtonHandler : MonoBehaviour
{
    public Button creditButton;

    void Start()
    {
        // Pastikan button terhubung
        if (creditButton != null)
        {
            creditButton.onClick.AddListener(OnCreditButtonClick);
        }
    }

    void OnCreditButtonClick()
    {
        // Ganti scene ke CreditScene
        SceneManager.LoadScene("Credit");
    }
}
