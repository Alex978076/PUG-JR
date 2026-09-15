using UnityEngine;

public class Moedas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PJ")) ;
        {
            Destroy(this.gameObject);
            print("Você pegou uma moeda");

        }

    }


}
    
        
