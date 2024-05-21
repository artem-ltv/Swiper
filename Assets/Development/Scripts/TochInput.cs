using UnityEngine;
using UnityEngine.EventSystems;

namespace Swiper
{
    public class TochInput : MonoBehaviour, IBeginDragHandler, IDragHandler
    {
        [SerializeField] private PlayerMover _playerMover;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if(Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {
                if(eventData.delta.x > 0)
                {
                    _playerMover.Move(Vector3.right);
                }

                else
                {
                    _playerMover.Move(Vector3.left);
                }
            }

            else
            {
                if (eventData.delta.y > 0)
                {
                    _playerMover.Move(Vector3.up);
                }

                else
                {
                    _playerMover.Move(Vector3.down);
                }
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
        }
    }
}
