using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este método carga el juego
    public void PlayGame()
    {
        // Asegúrate de que tu primer nivel está en el Build Settings
        SceneManager.LoadScene("OldMachineRoom_A");
    }

    // Este método cierra la aplicación
    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
