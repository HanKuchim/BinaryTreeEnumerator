using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNew
{
    public class TreeEnumerator : IEnumerator<Node>
    {
        private readonly Queue<Node> _queue;

        public TreeEnumerator(Node root)
        {
            _queue = new Queue<Node>();
            _queue.Enqueue(root);
        }

        public Node Current => _queue.Peek();

        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            if (_queue.Count == 0)
            {
                return false;
            }

            var node = _queue.Dequeue();

            if (node.Left != null)
            {
                _queue.Enqueue(node.Left);
            }

            if (node.Right != null)
            {
                _queue.Enqueue(node.Right);
            }

            return true;
        }
        public void Reset()
        {
            throw new NotSupportedException();
        }
        public void Dispose()
        {
            
        }
    }

}
