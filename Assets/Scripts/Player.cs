using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _player;
    private Animator _anim;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        if (_anim == null)
        {
            Debug.LogError("Player::Animator is null");
        }
        //if player is pressing a or left
        //player walks to left
        //if player is pressing d or right
        //flip x is true and move player to the right

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMov();
    }

    private void PlayerMov()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            _player.flipX = true;
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            _anim.SetBool("Walking", true);
        }
        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            _player.flipX = false;
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            _anim.SetBool("Walking", true);
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            _anim.SetBool("Walking", false);
        }
    }
}
