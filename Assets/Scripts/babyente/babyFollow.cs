using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollectableCollect : MonoBehaviour
{
    public float delayDestroy = 1f;

    GameObject player;
    AudioSource collectableAudio;
    ParticleSystem collectParticles;

    private void Awake()
    {
        // Get the component of type <Rigidbody> from the gameobject this script is attached to. 
        player = GameObject.FindGameObjectWithTag("Player");

        collectableAudio = GetComponent<AudioSource>();
        collectParticles = GetComponentInChildren<ParticleSystem>();
    }

    // this function gets called as soon as the sphere hits another 3d object with a collider attached
   private void OnTriggerEnter(Collider other)
    {
        // check if the other gameobject has the tag "Collectable"
        if (other.gameObject == player)
        {
            collectableAudio.Play();
            collectParticles.Play();

            Invoke("DeactivateCollectable", delayDestroy);
            // set the gameobject inactive
            //gameObject.SetActive(false);
        }
    }

    private void DeactivateCollectable()
    {
        gameObject.SetActive(false);
    }
}
