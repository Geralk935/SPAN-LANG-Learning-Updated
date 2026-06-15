using UnityEngine;

public class AudioHolder : MonoBehaviour
{
    [SerializeField]
	private static AudioClip audio00, audio01, audio02, audio03, audio04, audio05, audio06, audio07, audio08, audio09, audio10, audio11; 
    public AudioClip[] array = new AudioClip[] {audio00, audio01, audio02, audio03, audio04, audio05, audio06, audio07, audio08, audio09, audio10, audio11};
}
