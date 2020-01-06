using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public static class pubsubsystem
    {
        /// <summary>
        /// A dictionary with an event type as a publisher, and a list of actions (events) as listener methods.
        /// </summary>
        private static Dictionary<Type, List<Action<object>>> _listeners = new Dictionary<Type, List<Action<object>>>();

        public static void AddListener<T>(Action<object> actiontoadd)where T:class
        {

            //check if there is an entry in the dictionary with the type of event we want to add
            //if not add an entry to the dictionary with an empty list of actions
            if (!_listeners.ContainsKey(typeof(T)))
            {
                //Debug.Log("actiontoadd: "+actiontoadd.Method);
                _listeners.Add(typeof(T),new List<Action<object>>());

            }
            //add the action at the type entty of the dictionary
            _listeners[typeof(T)].Add(actiontoadd);

        }

        public static void RemoveAllListeners() {

            _listeners.Clear();
        
        }

        public static void RemoveListener<T>(Action<object> actiontoremove)
        {
            if (!_listeners.ContainsKey(typeof(T)))
            {
                //Debug.Log("actiontoadd: "+actiontoadd.Method);
                Debug.LogError("No such eventtype in list!");

            }

            else
            {

                _listeners[typeof(T)].Remove(actiontoremove);


            }


        }


        public static void PublishToListeners<T>(T publishedEventArgs)where T:class
        {

            //check if there is a key of type t in our dictionary if not return
            if (!_listeners.ContainsKey(typeof(T))) {

                Debug.LogError("no such entry in the dictionary, cant publish: "+typeof(T));
                return;
            }

            //call all actions in the list of type t in the dicionary, with the passed publishedeventargs arguments
            foreach (var action in _listeners[typeof(T)])
            {
                action.Invoke(publishedEventArgs);

            }
          
        }

    }
}
