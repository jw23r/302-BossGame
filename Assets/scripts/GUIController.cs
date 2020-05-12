using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    public Image playerHealthBar;
    public Image enemyHealthBar;
   static public float enemeyHelath = 1000;
    static public float playerHealth = 100;
     float maxEnemeyHelath;
     float maxPlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxEnemeyHelath = enemeyHelath;
        maxPlayerHealth = playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthBar.fillAmount = playerHealth / maxPlayerHealth;
        enemyHealthBar.fillAmount = enemeyHelath / maxEnemeyHelath;

    }
}
