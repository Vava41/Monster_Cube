using UnityEngine;

public class Green_Leg : MonoBehaviour
{
    public float scaleFactor = 2.0f; // Facteur d'agrandissement sur l'axe Y



    public int limite = 10;
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
            ScaleOnZ();
            //compteur += 1;
            fmod_stretch();
        }


        if (Input.GetKey(KeyCode.Joystick1Button0)) // Utilise le bon index de bouton en fonction de ta manette
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnZ();
            //compteur += 1;
            fmod_stretch();
        }
        if (Input.GetKey(KeyCode.O))
        {
            compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
            // Retour taille initiale
            transform.localScale = new Vector3(0.20f, 0.20f, 0.30f);
            compteur = 0;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
            // Retour taille initiale
            transform.localScale = new Vector3(0.20f, 0.20f, 0.30f);
        }
    }

    void ScaleOnZ()
    {
        // Redimensionne le cube uniquement sur l'axe Z
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + 1 * Time.deltaTime);
        if (transform.localScale.x >= limite)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, limite);
        }



        //Limite
        if (compteur == limite)
        {
            compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
            transform.localScale = new Vector3(0.20f, 0.20f, 0.30f);

        }
        if (compteur == sat)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/saturation");
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
}



