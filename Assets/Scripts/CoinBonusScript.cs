using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class CoinBonusScript : MonoBehaviour
{
    public GameObject CoinBonus;
    public GameObject CoinBoomParticleSystem;
    public GameObject CoinPS;    

    private Animator animCoin;
    private AudioSource boom;
    private bool flag = false;
    
    private void Start()
    {        
        animCoin = GetComponent<Animator>();
        boom = GetComponent<AudioSource>();        
    }        
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {            
            CoinPS.SetActive(false);
            CoinBoomParticleSystem.SetActive(true);
            animCoin.SetTrigger("CoinBonusTrigger");
            flag = true;
            Invoke("DestroyCoin", 1f);
            boom.Play();            
        }        
    }

    private void DestroyCoin()
    {
        if (flag == true)
        {
            Destroy(CoinBonus);
        }
    }    
}
