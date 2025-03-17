using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        if (player.position.z >= 99999)
        {
        
        } else
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
