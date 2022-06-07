using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogics : MonoBehaviour
{
    [SerializeField] private GameObject ParkingPlace;
    [SerializeField] private GameObject SuccessPanel;
    [SerializeField] private GameObject ParkButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Renderer ParkingPlace_parrender = ParkingPlace.GetComponent<Renderer>();
        ParkingPlace_parrender.material.color = Color.green;
        
 

        ParkButton.SetActive(true);
        if (other.gameObject.tag == "ParkingPlace")
        {
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Renderer ParkingPlace_parrender = ParkingPlace.GetComponent<Renderer>();
        ParkingPlace_parrender.material.color = Color.white;
        ParkButton.SetActive(false);

        if (other.gameObject.tag == "ParkingPlace")
        {
           
        }
    }

    public void ParkButtonSuccess()
    {
        SuccessPanel.SetActive(true);
        ParkButton.SetActive(false);
        Coins_Manager.IncreaseCoins(20);
    }
}
