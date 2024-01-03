using UnityEngine;

public class Red_Leg : MonoBehaviour
{
    //public float scaleFactor = 2.0f; // Facteur d'agrandissement sur l'axe Y
    public float speed = 5f;



    public float limite = 10f;
    public int sat = 8;
    private int compteur = 0;

    [SerializeField] public bool G2;
    public Transform _parent;


    void Update()
    {
        // V�rifie si la barre d'espace est enfonc�e
        if (Input.GetKey(KeyCode.E))
        {
            // Redimensionne le cube sur l'axe X
            ScaleOnX();
            //compteur += 1;
            //fmod_stretch();
        }


        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            // Redimensionne le cube sur l'axe X
            ScaleOnX();
            //compteur += 1;
            //fmod_stretch();
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

    void ScaleOnX()
    {
        // Redimensionne le cube uniquement sur l'axe X
        if (transform.localScale.x < limite)
        {
            transform.localScale = new Vector3(transform.localScale.x + speed * Time.deltaTime, transform.localScale.y, transform.localScale.z);
        }



        //Limite
        //if (compteur == limite)
        //{
        //    compteur = 0;
        //    transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
            // Retour taille initiale
        //    transform.localScale = new Vector3(0.30f, 0.20f, 0.20f);

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
        G2 = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/boing");
        G2 = true;
    }
    void Reset()
    {
        compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);

            // Retour taille initiale
            transform.localScale = new Vector3(1f, 1f, 1f);
    }

}



