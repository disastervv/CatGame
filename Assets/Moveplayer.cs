using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    [SerializeField] int speed = 4;
    Vector2 _playerInput;
    Rigidbody2D _rigidBody;
    Animator _animator;
    SpriteRenderer _spriteRenderer;

    

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void CheckInput()
    {
		_playerInput = Vector2.ClampMagnitude(
			new Vector2(
				Input.GetAxisRaw("Horizontal"),
				Input.GetAxisRaw("Vertical")
			),
		1f);
    }
    

    void Update()
    {
      
          CheckInput() ;
        
        
    }
    void FixedUpdate() {
        _rigidBody.MovePosition(
            transform.position + new Vector3(
                _playerInput.x,
                _playerInput.y,
                0f
            ) * Time.deltaTime * speed
        );
    }
}