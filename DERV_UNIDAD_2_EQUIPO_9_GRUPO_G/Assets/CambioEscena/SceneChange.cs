using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoScore;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if(escenaActiva == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cambioDeEscena(1);
            }
            if (escenaActiva == 2)
            {
                textoScore.text=PlayerPrefs.GetInt("Score", 0).ToString();
            }
        }
    }
    public void cambioDeEscena(int index)
    {
        SceneManager.LoadScene(index);
    }
public void cambioDeEscena(int index, int score)
    {
        PlayerPrefs.SetInt("Score", score);
        cambioDeEscena(index);
    }
}
