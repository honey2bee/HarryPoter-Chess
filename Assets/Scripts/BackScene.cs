using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackScene : MonoBehaviour
{
    public void OnMouseDown(){ //문 클릭하면 메뉴씬으로 돌아가기
        SceneManager.LoadScene("menu");
    }
}
