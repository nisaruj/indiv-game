using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class HealthUI : MonoBehaviour
{
    private ThirdPersonCharacter player;
    private Text healthDisplay;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<ThirdPersonCharacter>();
        healthDisplay = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = 'x' + player.currentHP.ToString();
    }
}
