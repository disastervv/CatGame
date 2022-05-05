using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject _player;
    void Start()
    {
        
    }

    void Update()
    {

        if(_player != null)
        {
            transform.position = new Vector3(
            _player.transform.position.x,
            _player.transform.position.y,
            -10
        );
        }
       
    }
}