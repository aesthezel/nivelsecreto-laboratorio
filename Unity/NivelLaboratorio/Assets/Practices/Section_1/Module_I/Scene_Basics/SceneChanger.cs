// Librerias
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName;
    [SerializeField] private int SceneNumber;

    public void GoToScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    #region Funciones de Eventos de Unity
    void Start() // Se ejecuta 1 sola vez al inicio de nuestro juego, es decir se ejecuta cuando le damos al PLay y el objeto que posea el componente este activo.
    {
        
    }

    void Update() // Se ejecuta cada frame de Unity en base a los fps de nuestro ordenador
    {
        
    }
    #endregion
}
