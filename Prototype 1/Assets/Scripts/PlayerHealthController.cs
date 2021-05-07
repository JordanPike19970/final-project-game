using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthController : MonoBehaviour
{
    private int healthInitial = 3;
    private int healthCurrent;
    // Start is called before the first frame update
    void Start()
    {
        ResetHealth();
    }

    public void ResetHealth()
    {
        healthCurrent = healthInitial;
    }

    public void TakeDamage(int damageAmount)
    {
        healthCurrent -= damageAmount;

        if(healthCurrent <= 0)
        {
            SceneManager.LoadScene("Finish");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
