using UnityEngine;

public class Blue_Leg : MonoBehaviour
{
    //public float scaleFactor = 1.5f; // Facteur d'agrandissement sur l'axe Y
    public float speed = 5f;



    public int limite = 0;
    public int sat = 8;
    private int compteur = 0;

    [SerializeField] public bool G3;
    public Transform _parent;


    void Update()
    {
        // Mouse
        if (Input.GetKey(KeyCode.Q))
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            fmod_stretch();
        }


        // Controller
        if (Input.GetKey(KeyCode.Joystick1Button2)) 
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            fmod_stretch();

        }
        if (Input.GetKey(KeyCode.O))
        {
            Reset();
        }



        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            Reset();
        }
    }

    void ScaleOnY()
    {
        // Redimensionne le cube uniquement sur l'axe Y
        if (transform.localScale.y < limite)
        {
            transform.localScale = new Vector3(transform.localScale.x + speed * Time.deltaTime, transform.localScale.y,  transform.localScale.z);
        }



        ////Limite
        //if (compteur == limite)
        //{
        //    compteur = 0;
        //    transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
        //    transform.localScale = new Vector3(0.20f, 0.30f, 0.20f);

        //}
        if (compteur == sat)
        {
            //FMODUnity.RuntimeManager.PlayOneShot("event:/saturation");
        }



    }
    void fmod_stretch()
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/etirement");
    }
    private void OnCollisionExit(Collision collision)
    {
        G3 = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/boing");
        G3 = true;
    }
    void Reset()
    {
        compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);

            // Retour taille initiale
            transform.localScale = new Vector3(1f, 21.9793f, 1f);
    }

}



