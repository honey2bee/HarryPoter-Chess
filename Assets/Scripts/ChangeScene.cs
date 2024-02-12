using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn() {
        switch (this.gameObject.name) {
            case "btn_with_AI":
                SceneManager.LoadScene("chess");
                break;
            case "btn_random_matching":
                break;
        }
    }
}
