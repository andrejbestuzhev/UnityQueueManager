using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class QueueManager : MonoBehaviour
    {
        private List<Action> Actions;
        public static QueueManager Instance { get; private set; }


        public void Start()
        {
            this.Actions = new List<Action>();
            Instance = this;
        }

        public void Update()
        {
            if (this.Actions.Count > 0) {
                for (int i = 0; i < this.Actions.Count; i++) {
                    try {
                        this.Actions[i].Invoke();
                    }
                    catch (Exception e) {
                        this.Actions.RemoveAt(i);
                        throw e;
                    }
                }
                this.Actions.Clear();
            }
        }

        public void Enqueue(Action action)
        {
            this.Actions.Add(action);
        }
    }
}
