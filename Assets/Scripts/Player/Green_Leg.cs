using UnityEngine;

public class Green_Leg : MonoBehaviour
{
    //public float scaleFactor = 2.0f; // Facteur d'agrandissement sur l'axe Y
    public float speed = 5f;
    public float resetSpeed = 5f;



    public float limite = 10;
    public int sat = 8;
    private int compteur = 0;

    [SerializeField] public bool G1;
    public Transform _parent;

    void Update()
    {
        // V�rifie si la barre d'espace est enfonc�e
        if (Input.GetKey(KeyCode.Space))
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            //fmod_stretch();
        }


        if (Input.GetKey(KeyCode.Joystick1Button0)) // Utilise le bon index de bouton en fonction de ta manette
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            //fmod_stretch();
        }
        if (Input.GetKey(KeyCode.R))
        {
            Reset();
        }


        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            Reset();
        }
    }

    void ScaleOnY()
    {
        // Redimensionne le cube uniquement sur l'axe Y
        if (transform.localScale.y < limite)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + speed * Time.deltaTime, transform.localScale.z);
        }



        ////Limite
        //if (compteur == limite)
        //{
        //    compteur = 0;
        //    transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
        //    transform.localScale = new Vector3(0.20f, 0.20f, 0.30f);
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
        G1 = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/boing");
        G1 = true;
    }
    void Reset()
    {
        compteur = 0;
        transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);

        // Retour taille initiale
        if (transform.localScale.y > 0.09712829f)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y - resetSpeed * Time.deltaTime, 1.137281f);
        }
    }
}



