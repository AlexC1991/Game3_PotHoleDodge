using UnityEngine;
using UnityEngine.SceneManagement;
namespace AlexzanderCowell
{
    public class SceneResetScript : MonoBehaviour
    {
        private void Update()
        {
            if (GameUIScript.resetGameNow)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameUIScript.resetGameNow = false;
            }
        }
    }
}
