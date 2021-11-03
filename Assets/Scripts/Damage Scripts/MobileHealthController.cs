using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MobileHealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] public Text healthText;
    [SerializeField] public GameObject deathAni;

    //Animator myAnimator;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("1");
        //Can use this area to reset level when SlimePaul dies

        if(playerHealth <= 0)
        {
            //GameObject death = Instantiate(deathAni) as GameObject;
            //death.transform.position = transform.position;
            //this.gameObject.SetActive(false);

            //myAnimator.SetBool("IsDead", true);
            //deathAni.gameObject.SetActive(true);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Reset");
        }
    }
}
