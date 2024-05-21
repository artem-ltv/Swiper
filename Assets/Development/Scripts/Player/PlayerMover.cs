using UnityEngine;

namespace Swiper
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _step;

        private Vector3 _targetPosition;

        private void Update()
        {
            if(transform.position != _targetPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
            }
        }

        public void Move(Vector3 direction)
        {
            direction *= _step;

            _targetPosition = new Vector3(transform.position.x + direction.x, transform.position.y + direction.y);
        }
    }
}
