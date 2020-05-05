using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CoinUI : MonoBehaviour
{
    private ThirdPersonCharacter player;
    private Text coinDisplay;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<ThirdPersonCharacter>();
        coinDisplay = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.text = 'x' + player.coinAmount.ToString();
    }
}
